using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidBody;

    public void Init()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.velocity = transform.forward * _speed;
    }
}

