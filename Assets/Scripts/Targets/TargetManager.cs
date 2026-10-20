using System;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private GameObject basePrefab;

    private void Start()
    {
        TargetBuilder builder = new TargetBuilder(basePrefab);
    }
}
