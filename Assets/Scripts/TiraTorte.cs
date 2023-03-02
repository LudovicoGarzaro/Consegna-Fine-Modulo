using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiraTorte : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject tortaPrefab;
    public float bulletspeed = 10;

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            
            var torta = Instantiate(tortaPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            torta.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
        } 
    }
}
