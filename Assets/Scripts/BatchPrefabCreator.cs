using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchPrefabCreator : MonoBehaviour
{
    public Transform[] Spawn;
    public GameObject Prefab;

    [ContextMenu ("Create")]
    public void Create()
    {
        for (int i = 0; i < Spawn.Length; i++)
        {
            Instantiate(Prefab, Spawn[i].position, Spawn[i].rotation);
        }
    }
}
