using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int Health=5;
    public int MaxHealth=8;

    bool _invulnerable = false;


    public AudioSource AddHealthSound;

    public HealthUI HealthUI;

    public UnityEvent EventOnTakeDamage;

    private void Start()
    {
        HealthUI.Setup(MaxHealth);
        HealthUI.ShowHealth(Health);
    }

    public void TakeDamage(int damageValue)
    {
        if (_invulnerable == false)
        {
            Health -= damageValue;
            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
            _invulnerable = true;
            Invoke("StopInvulnerable", 1f);
        }
        HealthUI.ShowHealth(Health);
        EventOnTakeDamage.Invoke();
    }
    void StopInvulnerable()
    {
        _invulnerable = false;
    }

    public void AddHealth(int healthValue)
    {
        Health += healthValue;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        AddHealthSound.Play();
        HealthUI.ShowHealth(Health);
    }


    public void Die()
    {
        Debug.Log("You Lose");
    }
}
