using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torta : MonoBehaviour
{



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Life>(out Life lifeComponent))
        {
            lifeComponent.TakeDamage(1);
        }

        if (collision.collider.tag == "Player")
        {


            if (collision.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth playerlifeComponent))
            {
                playerlifeComponent.TakeDamagePlayer(1);
            }
        }
        Destroy(gameObject);

    }
}