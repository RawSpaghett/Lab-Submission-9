using UnityEngine;

[CreateAssetMenu(fileName = "NewTargetData", menuName = "ScriptableObjects/TargetData", order = 1)]
public class TargetPreset : ScriptableObject
{
    public string targetName;
    public float scoreValue;
    public Vector2 position;
    public Sprite sprite;
}