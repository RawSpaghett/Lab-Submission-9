using System;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private GameObject basePrefab;
    [SerializeField] private TargetPreset[] presetArray;

    private void Start()
    {
        TargetBuilder builder = new TargetBuilder(basePrefab);

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
}
