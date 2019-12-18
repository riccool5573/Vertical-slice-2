using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private int sprintspeed;
    private bool isSprinting;
    public Rigidbody RB;

    void Start()
    {
        sprintspeed = speed * 2;
    }

    void Update()

    {
        RB.velocity = new Vector3(0, 0, 0);
        Debug.Log(isSprinting);
       
        
        RB.velocity = transform.forward * Input.GetAxis("Vertical") * speed;
        isSprinting = false;
        if (Input.GetButton("Sprint"))
        {
            isSprinting = true;
            Debug.Log("got here");
        }
        if (Input.GetKey(KeyCode.W))
        {
            RB.velocity = transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            RB.velocity = -transform.right * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            RB.velocity = -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            RB.velocity = transform.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        
        if (isSprinting )
        {
            speed = sprintspeed;
        }
        if (!isSprinting)
        {
            speed = sprintspeed / 2;
        }
    }
}
