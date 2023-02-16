using System.Collections;
using System.Collections.Generic;
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
        Vector3 velocity = (Vector3.forward * zMove + Vector3.right * xMove).normalized * speed; //* Time.deltaTime ;
        velocity.y = rb.velocity.y;
        //transform.position = transform.position + playerMovement;

        if(velocity != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(velocity, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }


        //Applico la traslazione
        //transform.Translate(playerMovement, Space.World);

        
        velocity.y = rb.velocity.y;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //velocity.y += Mathf.Sqrt(jumpForce * -2f * (-9.81f));
        }

        rb.velocity = velocity;

        Debug.DrawRay(transform.position, -transform.up * 10, Color.red);

        //RaycastHit hit;
       // if(Physics.Raycast(transform.position, -transform.up, out hit, 10, groundMask))
       // {
            //Debug.Log("Colpito");
       // }

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

        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}

