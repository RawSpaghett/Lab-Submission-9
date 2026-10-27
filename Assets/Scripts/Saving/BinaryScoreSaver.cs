using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SocialPlatforms.Impl;

public class BinaryScoreSaver
{
    private PlayerInputScript playerInput;
    BinaryFormatter formatter = new BinaryFormatter();
    MemoryStream stream = new MemoryStream();
    public Scoreboard scoreBoard;
    private byte[] binaryData;
    
    void Awake()
    {
        
    }

    public void SaveScoreData()
    {
        formatter.Serialize(stream, scoreBoard.CaptureState());
        binaryData = stream.ToArray();
    }

    public void LoadScoreData()
    {
        stream = new MemoryStream(binaryData);
         var deserializedObject = (int)formatter.Deserialize(stream);
         scoreBoard.LoadState(deserializedObject);
    }
    
}
