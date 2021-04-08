using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSpawn : MonoBehaviour
{
    public GameObject CarrotPrefab;
    public Transform Spawn;

    public void Spawner()
    {
        Instantiate(CarrotPrefab, Spawn.position, Quaternion.identity);
    }
}
