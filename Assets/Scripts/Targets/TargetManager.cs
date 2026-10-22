using System;
using UnityEngine;



public class TargetManager : MonoBehaviour
{
    [SerializeField] private GameObject basePrefab;
    [SerializeField] private TargetPreset[] presetArray;
    private TargetBuilder builder;
    float radius = 5f;

    private void OnEnable()
    {
        EventBus.OnTargetHit += SpawnRandom;
    }

    private void OnDisable()
    {
        EventBus.OnTargetHit -= SpawnRandom;
    }

    private void Start()
    {
        builder = new TargetBuilder(basePrefab);

        foreach (TargetPreset preset in presetArray)
        {
            builder
                .WithName(preset.name)
                .WithValue(preset.scoreValue)
                .WithPosition(preset.position)
                .WithSprite(preset.sprite)
                .Build();
        }
    }

    private void SpawnRandom(TargetBase T)
    {
        int randomPreset = UnityEngine.Random.Range(0, presetArray.Length);
        Vector2 randomPoint = UnityEngine.Random.insideUnitCircle * radius;
        builder
            .WithName(presetArray[randomPreset].name)
            .WithValue(presetArray[randomPreset].scoreValue)
            .WithPosition(randomPoint)
            .WithSprite(presetArray[randomPreset].sprite)
            .Build();
    }
    
    
    
}
