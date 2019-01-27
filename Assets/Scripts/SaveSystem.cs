using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour {

	public static void SaveShape(Shapes shape)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/shapeD.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        PrefabData data = new PrefabData(shape);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PrefabData LoadShape()
    {
        string path = Application.persistentDataPath + "/shapeD.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PrefabData data = formatter.Deserialize(stream) as PrefabData;
            stream.Close();
            return data;

        }
        else
        {
            Debug.LogError(" Shapen file not found in " + path);
            return null;
        }
    }
    public static void SaveShapes( )
    {
         BinaryFormatter formatter = new BinaryFormatter();
         string path = Application.persistentDataPath + "/prefD.fun";
         FileStream stream = new FileStream(path, FileMode.Create);
        Shapes[] sha = (Shapes[])GameObject.FindObjectsOfType(typeof(Shapes));
        Debug.Log("Count " + sha.Length);
        PrefabsD data = new PrefabsD();
        foreach (Shapes sa in sha)
        {
            ShapeData sd = new ShapeData(sa);
            data.AddShape(sd);
        }
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PrefabsD LoadShapes()
    {
        string path = Application.persistentDataPath + "/prefD.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PrefabsD data = formatter.Deserialize(stream) as PrefabsD;
            stream.Close();
            return data;

        }
        else
        {
            Debug.LogError(" Shapen file not found in " + path);
            return null;
        }
    }

      
}
