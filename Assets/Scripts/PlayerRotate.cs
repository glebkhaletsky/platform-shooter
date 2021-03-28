using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public Transform Pointer;

    private void Update()
    {
        if (Pointer.position.x > 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.EulerAngles(0, 60, 0), 5f);
        }
    }
}
