using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShapeData
{

    public float[] position;

    public ShapeData(Shapes shapes)
    {
        position = new float[3];
        position[0] = shapes.transform.position.x;
        position[1] = shapes.transform.position.y;
        position[2] = shapes.transform.position.z;


    }
}
