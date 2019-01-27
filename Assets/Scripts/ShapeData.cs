using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShapeData
{

    public float[] position;
    public float[] rotation;
    public float[] scale;
    public string PrefabTag;

    public ShapeData(Shapes shapes)
    {
        position = new float[3];
        position[0] = shapes.transform.position.x;
        position[1] = shapes.transform.position.y;
        position[2] = shapes.transform.position.z;
        rotation = new float[3];
        rotation[0] = shapes.transform.rotation.x;
        rotation[1] = shapes.transform.rotation.y;
        rotation[2] = shapes.transform.rotation.z;
        scale = new float[3];
        scale[0] = shapes.transform.localScale.x;
        scale[1] = shapes.transform.localScale.y;
        scale[2] = shapes.transform.localScale.z;
        PrefabTag = shapes.tag;
        Debug.Log(PrefabTag);

    }
}
