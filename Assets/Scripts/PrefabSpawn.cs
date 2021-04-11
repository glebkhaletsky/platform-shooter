using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawn : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawn;

    public void Spawner()
    {
        Instantiate(Prefab, Spawn.position, Spawn.rotation);
    }
}
