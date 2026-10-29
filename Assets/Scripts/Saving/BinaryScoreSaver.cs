using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SocialPlatforms.Impl;

public class BinaryScoreSaver : MonoBehaviour
{
    private PlayerInputScript playerInput;
    BinaryFormatter formatter = new BinaryFormatter();
    MemoryStream stream = new MemoryStream();
    private Scoreboard scoreBoard;
    private byte[] binaryData;

    void Awake()
    {
        GameObject tmp = GameObject.Find("Canvas");
        scoreBoard = tmp.GetComponentInChildren<Scoreboard>();
    }

    public void SaveScoreData()
    {
        using (MemoryStream stream = new MemoryStream())
        {
            formatter.Serialize(stream, scoreBoard.CaptureState());
            binaryData = stream.ToArray();
        }
    }

    public void LoadScoreData()
    {
        stream = new MemoryStream(binaryData);
        var deserializedObject = (Scoreboard.ScoreboardData)formatter.Deserialize(stream);
        scoreBoard.LoadState(deserializedObject);
    }

}
