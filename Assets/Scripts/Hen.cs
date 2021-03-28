using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public Rigidbody Rigidbody;
    Transform _playerTransform;

    public float Speed;
    public float TimeToReachSpeed;
    private void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }
    private void Update()
    {
        Vector3 toPlayer = (_playerTransform.position - transform.position).normalized;
        Vector3 force = Rigidbody.mass * (toPlayer * Speed - Rigidbody.velocity) / TimeToReachSpeed;
        Rigidbody.AddForce(force);

    }
}
