using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helthManager : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
   
    private void Start()
    {
        updateMaxHealth(maxHelth);
    }
    public void DamageCharacter(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
