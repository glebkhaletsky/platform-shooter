using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float SpeedX, SpeedY, SpeedZ;
    void Update()
    {
        transform.Rotate(SpeedX, SpeedY, SpeedZ);
    }
}
