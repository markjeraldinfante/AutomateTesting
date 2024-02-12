using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EntityHealth : IHealth
{
    private float currentHealth;
    public float CurrentHealth { get { return currentHealth; }
        set 
        {
            currentHealth = value;
        } 
    }
    public void Damage(float damageAmount)
    {
        if (currentHealth > 0)
        currentHealth -= damageAmount;
    }

    public void Heal(float healAmount)
    {
        if (currentHealth < 100)
        currentHealth += healAmount;
    }
}
