using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTargetEuler : MonoBehaviour
{
    public Vector3 LeftTarget;
    public Vector3 RightTarget;
    private Vector3 _toTarget;

    public float RotationSpeed;

    private void Update()
    {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(_toTarget), Time.deltaTime * RotationSpeed);
    }

    public void ToLeft()
    {
        _toTarget = LeftTarget;
    }
    public void ToRight()
    {
        _toTarget = RightTarget;
    }
}
