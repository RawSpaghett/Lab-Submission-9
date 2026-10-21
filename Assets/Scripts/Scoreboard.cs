using System;
using Unity.VisualScripting;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private void OnEnable()
    {
        EventBus.OnTargetHit += UpdateScore;
    }

    private void OnDisable()
    {
        EventBus.OnTargetHit -= UpdateScore;
    }
    
    private void UpdateScore(TargetBase target)
    {}
}
