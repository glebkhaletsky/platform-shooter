using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakeDamageOnCollision : MonoBehaviour
{
    public EnemyHealth EnemyHealth;
    public UnityEvent EventOnTakeDamage;
    public bool DieToAnyCollision;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<Bullet>())
            {
                EnemyHealth.TakeDamage(1);
                EventOnTakeDamage.Invoke();
            }
        }
        if(DieToAnyCollision == true)
        {
            EnemyHealth.TakeDamage(100);
        }
    }
}
