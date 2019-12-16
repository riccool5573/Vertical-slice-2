using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int Speed;
    private bool isSprinting;
    // Update is called once per frame
    void Update()
    {
        isSprinting = false;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * Speed * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * Speed * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.forward * Speed * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * Speed * 0.1f);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        if (isSprinting)
        {
            Speed = 2;
        }
        if (!isSprinting)
        {
            Speed = 1;
        }
    }
}
