using UnityEngine;
using Random = UnityEngine.Random;

public class ColoringObject : Object
{
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    protected override void CollisionReaction()
    {
        var color = new Color(Random.value, Random.value, Random.value, 1f);
        _meshRenderer.material.color = color;
    }
}
