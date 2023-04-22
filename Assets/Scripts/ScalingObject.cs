
using UnityEngine;
using Random = UnityEngine.Random;

public class ScalingObject : Object
{
    private const float _minScale = 0.5f;
    private const float _maxScale = 1.5f;


    protected override void CollisionReaction()
    {
        var newScale = Random.Range(_minScale, _maxScale);
        transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}
