using UnityEngine;

public class TransformSaver : MonoBehaviour, ITransformSaveable, ISerializationCallbackReceiver
{
    [SerializeField] private string _saveID; //saved game name

    public string SaveID
    {
        get { return _saveID; }
        set { _saveID = value; }
    }
    
    public void OnBeforeSerialize()
    {
        if (string.IsNullOrEmpty(_saveID)) 
        {
            _saveID = System.Guid.NewGuid().ToString(); //128 bit random string, if empty
        }
    }

    public void OnAfterDeserialize() { }
    
    public TransformSaveData GetSaveData()
    {
        return new TransformSaveData
        {
            saveID = this.SaveID,
            localPosition = transform.localPosition,
            localRotation = transform.localRotation,
            localScale = transform.localScale
        };
    }
    
    public void LoadFromData(TransformSaveData data)
    {
        transform.localPosition = data.localPosition;
        transform.localRotation = data.localRotation;
        transform.localScale = data.localScale;
    }
}