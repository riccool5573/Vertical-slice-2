using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;

    public bool isGrounded;
    public bool isInTheAir = false;
    public int jumpHeight;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.z, jumpHeight);
            isGrounded = false;
            isInTheAir = true;
        }
        if(Input.GetKey(KeyCode.Space)&& !isGrounded && isInTheAir)
        {
            rb.velocity = new Vector3(rb.velocity.z, jumpHeight);
            isInTheAir = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
            isInTheAir = false;
        }
    }
}

