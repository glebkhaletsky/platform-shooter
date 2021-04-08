using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TakeDamageOnTrigger : MonoBehaviour
{
    public EnemyHealth EnemyHealth; 
    public UnityEvent EventOnTakeDamage;
    public bool DieToAnyCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<Bullet>())
            {
                EnemyHealth.TakeDamage(1);
                EventOnTakeDamage.Invoke();
            }
        }
        if (DieToAnyCollision == true)
        {
            if(other.isTrigger == false)
            {
                EnemyHealth.TakeDamage(100);
            }
            
        }
    }
}
