using UnityEngine;

public class TargetBase : MonoBehaviour
{
    public string targetName { get; private set; }
    public float scoreValue { get; private set; }
    public Vector2 position { get; private set; }
    public Sprite sprite { get; private set; }

    public void Initialize(string TargetName, float ScoreValue, Vector2 Position, Sprite Sprite)
    {
        targetName = TargetName;
        scoreValue = ScoreValue;
        position = Position;
        this.transform.position = position;
        sprite = Sprite;
        if (!this.TryGetComponent(out SpriteRenderer renderer))
        {
            renderer.sprite = sprite;
        }
    }
}
