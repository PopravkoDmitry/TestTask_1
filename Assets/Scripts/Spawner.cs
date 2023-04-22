using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectPrefab;
    private GameObject _currentObject;
    private MeshRenderer _mesh;
    [SerializeField] private Mashes _mashes;
    [SerializeField] private float _offset;
    [SerializeField] private float _spawnHeight;
    
    private void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _currentObject = Instantiate(_objectPrefab,
                new Vector3(Random.Range(_mesh.bounds.min.x + _offset, _mesh.bounds.max.x - _offset), _spawnHeight,
                    Random.Range(_mesh.bounds.min.z + _offset, _mesh.bounds.max.z - _offset)), Quaternion.identity);
            ChangeType();
        }
    }

    private void ChangeType()
    {
        var value = Random.Range(0, 3);
        switch (value)
        {
            case 0:
                _currentObject.AddComponent<ColoringObject>();
                break;
            case 1:
                _currentObject.AddComponent<ScalingObject>();
                break;
            case 2:
                _currentObject.AddComponent<ShapingObject>().SetScriptableObject(_mashes);
                break;
        }
    }
}

