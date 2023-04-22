using UnityEngine;
using Random = UnityEngine.Random;

public abstract class Object : MonoBehaviour
{
    protected Rigidbody _rigidbody;
    protected const float _speed = 5f;
    protected Vector3 _movement;

    protected void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _movement = new Vector3(Random.value, 0, Random.value).normalized * _speed;
    }

    protected void Update()
    {
        _rigidbody.velocity = _movement;
    }

    protected void OnCollisionEnter(Collision other)
    {
        _movement = Vector3.Reflect(_movement, other.contacts[0].normal);
        CollisionReaction();
    }

    protected virtual void CollisionReaction()
    {
        
    }
}
