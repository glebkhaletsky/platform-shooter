using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject EffectPrefab;

    private void Start()
    {
        Destroy(gameObject, 4f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(EffectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
