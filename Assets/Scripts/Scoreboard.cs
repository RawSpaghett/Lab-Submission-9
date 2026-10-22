using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private TMP_Text text;
    private float score;
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
}
