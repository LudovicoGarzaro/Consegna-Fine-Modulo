using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Rigidbody rb;
    [SerializeField] LayerMask groundMask;
    

    public int score = 0;

    bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //if (rb != null)
        //{
        //    Debug.Log(rb.mass);
        //}
        //else 
        //{
        //    Debug.LogError("Rigidbody not found");
        //}


    }

    
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");
        
        //Costruisco il vettore movimento
        Vector3 velocity = (transform.forward * zMove + transform.right * xMove).normalized * speed; //* Time.deltaTime ;
        velocity.y = rb.velocity.y;
        
        //Applico la traslazione
        //transform.Translate(playerMovement, Space.World);

        velocity.y = rb.velocity.y;

        float rotation = Input.GetAxisRaw("HorizontalRotation");

        transform.Rotate(Vector3.up * rotationSpeed * rotation * Time.deltaTime);

       
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //velocity.y += Mathf.Sqrt(jumpForce * -2f * (-9.81f));
        }

      

        
        rb.velocity = velocity;

        //Debug.DrawRay(transform.position, -transform.up * 10, Color.red);

        //RaycastHit hit;
        //if(Physics.Raycast(transform.position, -transform.up, out hit, 10, groundMask))
        //{
        //    Debug.Log("Colpito");

        //    Debug.Log(hit.transform.name);
        //}

        //Physics.SphereCast
        //Physics.OverlapSphere

       

        
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Collectible"))
        {
            score++;
            Debug.Log(score);
            Destroy(other.gameObject);
        }

        //if (other.transform.CompareTag("Ground"))
        //{
        //    isGrounded = true;
        //}

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}

