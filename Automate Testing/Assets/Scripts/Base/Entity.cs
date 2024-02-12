using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Entity : MonoBehaviour
{
   [SerializeField] private GameObject HealthPrefab;
   private EntityHealth health;
   private HealthUI healthUI;

    private void Awake()
    {
        health = new EntityHealth();
        health.CurrentHealth = 100f;


        GameObject healthPrefabInstance = Instantiate(HealthPrefab, transform);
        healthUI = healthPrefabInstance.GetComponent<HealthUI>();
    }
    private void Start()
    {
        //healthUI.UpdateLives(health.CurrentHealth);
    }

    public void TakeDamage(int damage)
    {
        health.Damage(damage);
      
        if (healthUI != null) { 
            healthUI.GetUpdateLife(health.CurrentHealth);
            healthUI.UpdateLives(health.CurrentHealth);
        };
    }

    public void Heal(int heal)
    {
        health.Heal(heal);
        if (healthUI != null)
        {
            healthUI.GetUpdateLife(health.CurrentHealth);
            healthUI.UpdateLives(health.CurrentHealth);
        };
    }

}

