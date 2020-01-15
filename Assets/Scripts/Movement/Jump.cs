using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;

    public bool isGrounded;
    public bool isInTheAir = false;
    public int jumpHeight;
    private bool doubleJump = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector3(rb.velocity.z, jumpHeight);
                isGrounded = false;
                isInTheAir = true;
                
            }
            else if (!Input.GetKeyDown(KeyCode.Space))
            {
                rb.drag = 0;
                doubleJump = true;
            }
        }

        else if (!isGrounded && isInTheAir)
        {
            if (Input.GetKeyDown(KeyCode.Space) && doubleJump)
            {
                rb.velocity = new Vector3(rb.velocity.z, jumpHeight);
                //isInTheAir = false;
                doubleJump = false;
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                gliding();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
           
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = false;
           

        }
    }

    private void gliding()
    {
        rb.drag = 5;
    }


}

