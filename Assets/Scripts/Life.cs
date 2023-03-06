using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] float Health, maxHealth = 5f;

    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(float damageAmmount)
    {
        Health -= damageAmmount;

        if(Health <= 0)
        {
            Destroy(gameObject);
        }
          
    }
}
