using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Vector3 LeftEuler;
    public Vector3 RightEuler;
    private Vector3 _eulerCenter;

    public float RotationSpeed = 5f;

    private Transform _playerTransform;

    private void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    private void Update()
    {
        if (transform.position.x < _playerTransform.position.x)
        {
            _eulerCenter = RightEuler;
        }

        if (transform.position.x > _playerTransform.position.x)
        {
            _eulerCenter = LeftEuler;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_eulerCenter), Time.deltaTime * RotationSpeed);
    }

}
