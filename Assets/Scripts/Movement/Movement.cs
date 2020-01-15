using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int speed;

    private bool isSprinting;




    void Update()
    {
        isSprinting = false;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * speed * 0.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed * 0.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.forward * speed * 0.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * 0.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        if (isSprinting)
        {
            speed = 5;
        }
        if (!isSprinting)
        {
            speed = 50;
        }
    }
}
