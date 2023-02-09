using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;


    void Start()
    {
        
    }

    
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        Vector3 playerMovementy = Vector3.forward * yMove * speed * Time.deltaTime;
        Vector3 playerMovementx = Vector3.right * xMove * speed * Time.deltaTime;
       
        transform.position += playerMovementx;
        transform.position += playerMovementy;
    }


}
