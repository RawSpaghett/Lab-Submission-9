using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

public class Scoreboard : MonoBehaviour, ISaveable
{
    private TMP_Text text;
    public float score;
    private void OnEnable()
    {
        EventBus.OnTargetHit += UpdateScore;
    }

    private void OnDisable()
    {
        EventBus.OnTargetHit -= UpdateScore;
    }

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void UpdateScore(TargetBase target)
    {
        score += target.scoreValue;
        text.text = $"Score: {score.ToString()}";
    }

    public object CaptureState()
    {
        return new ScoreboardData()
        {
            Score = score
        };
    }

    public void LoadState(object saveData)
    {
        if (saveData is ScoreboardData data)
        {
            this.score = data.Score;
            UpdateScore(null);
        }
    }
    
    [System.Serializable]
    private struct ScoreboardData
    {
        public float Score;
    }
}
