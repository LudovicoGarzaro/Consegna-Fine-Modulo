using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationSpeed = 5f;
    [SerializeField] Rigidbody rb;
  
    

    

  

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        


    }


    void Update()
    {
       //Movimento Player
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

       
        Vector3 velocity = (transform.forward * zMove + transform.right * xMove).normalized * speed; //* Time.deltaTime ;
        velocity.y = rb.velocity.y;
        rb.velocity = velocity;

       //Rotazione Player
        float rotation = Input.GetAxisRaw("HorizontalRotation");
        transform.Rotate(Vector3.up * rotationSpeed * rotation * Time.deltaTime);

        

    }  

}

