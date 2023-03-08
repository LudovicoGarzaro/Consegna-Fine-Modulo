using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int currentHealth, maxHealth = 10;

    public Healthbarsystem healthBar;

    void Start()
    {
        currentHealth = maxHealth;
       
        healthBar.SetMaxHealth(maxHealth);
        
    }

   
    public void TakeDamagePlayer(int damageAmmountPlayer)
    {
        currentHealth -= damageAmmountPlayer;

        healthBar.SetHealth(currentHealth);

    }

}
