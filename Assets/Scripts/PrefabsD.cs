using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PrefabsD
{ 

    public List<ShapeData> shapesA = new List<ShapeData>();

    public void AddShape(ShapeData shape)
    {
        
        this.shapesA.Add(shape);

    }
}