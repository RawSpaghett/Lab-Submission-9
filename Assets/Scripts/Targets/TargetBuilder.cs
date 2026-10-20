using UnityEngine;

public class TargetBuilder 
{
    private string _targetName;
    private float _scoreValue;
    private Vector2 _position;
    private Sprite _sprite;
    private GameObject _basePrefab;

    public TargetBuilder(GameObject BasePrefab)
    {
        _basePrefab = BasePrefab;
    }

    public TargetBuilder WithName(string targetName)
    {
        _targetName = targetName;
        return this;
    }

    public TargetBuilder WithValue(float scoreValue)
    {
        _scoreValue = scoreValue;
        return this;
    }

    public TargetBuilder WithPosition(Vector2 position)
    {
        _position = position;
        return this;
    }

    public TargetBuilder WithSprite(Sprite sprite)
    {
        _sprite = sprite;
        return this;
    }

    public GameObject Build()
    {
        GameObject newTarget = Object.Instantiate(_basePrefab);
        newTarget.name = _targetName;
        if (!newTarget.TryGetComponent(out TargetBase targetComp))
        {
            targetComp = newTarget.AddComponent<TargetBase>();
        }
        targetComp.Initialize(_targetName,_scoreValue,_position,_sprite);
        return newTarget;
    }
}
