using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public int Health;
    public GameObject EffectPrefab;
    public bool UseEffect;
    public UnityEvent DieEvent;
    

    public void TakeDamage (int damageValue)
    {
        Health -= damageValue;
        if (Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (UseEffect == true)
        {
            Instantiate(EffectPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            EffectPrefab = null;
        }        
        DieEvent.Invoke();
        Destroy(gameObject);
    }
}
