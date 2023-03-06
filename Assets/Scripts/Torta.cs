using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torta : MonoBehaviour
{

    [SerializeField] float Damage = 1f;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Life>(out Life lifeComponent))
        {
            lifeComponent.TakeDamage(Damage);
        }

        Destroy(gameObject);
    }
}
