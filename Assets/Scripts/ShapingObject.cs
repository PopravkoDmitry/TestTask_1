using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShapingObject : Object
{
    private MeshFilter _meshFilter;
    private Mashes _mashes;

    private void Start()
    {
        _meshFilter = GetComponent<MeshFilter>();
    }

    public void SetScriptableObject(Mashes mashes)
    {
        _mashes = mashes;
    }

    protected override void CollisionReaction()
    {
        var value = Random.Range(0, 3);
        _meshFilter.mesh = value switch
        {
            0 => _mashes.CubeMesh,
            1 => _mashes.CylinderMesh,
            2 => _mashes.SphereMesh,
            _ => _meshFilter.mesh
        };
    }
}
