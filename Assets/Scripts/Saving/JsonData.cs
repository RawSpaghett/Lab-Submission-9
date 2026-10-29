using System;
using System.Collections.Generic;
using UnityEngine;

public interface ITransformSaveable //seperate interface from binary
{
    string SaveID { get; }
    TransformSaveData GetSaveData();
    void LoadFromData(TransformSaveData data);
}

[Serializable] //marked for serialization
public class TransformSaveData
{
    public string saveID;
    public Vector3 localPosition;
    public Quaternion localRotation;
    public Vector3 localScale;
}

[Serializable]//marked for serialization
public class SaveFileContainer
{
    public List<TransformSaveData> objects = new List<TransformSaveData>(); //list of custom class 
}