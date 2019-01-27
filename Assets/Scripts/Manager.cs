using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public void SaveShapeS()
    {
        SaveSystem.SaveShapes();
    }

    public void LoadShapeS()
    {
        PrefabsD data = SaveSystem.LoadShapes();
        foreach(ShapeData sd in data.shapesA)
        Debug.Log(sd.position[0]+" "+sd.PrefabTag+" " + sd.scale[0] + " "+ sd.rotation[0]);
    }
}
