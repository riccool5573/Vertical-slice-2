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
        isSprinting = false;//geluid voor lopen doet raar en getkeydown werkt niet met lopen, want dan kom je amper naar voren
        if (Input.GetKey(KeyCode.W))
        {          
            transform.Translate(transform.forward * speed * 0.1f * Time.fixedDeltaTime);
            
           // walkingSoundOn();


        }
        //else { walkingSoundOff(); }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-transform.right * speed * 0.1f * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(-transform.forward * speed * 0.1f * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(transform.right * speed * 0.1f * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        if (isSprinting)
        {
            speed = 50;
        }
        if (!isSprinting)
        {
            speed = 5;
        }

    }

    void walkingSoundOn()
    {
        FindObjectOfType<audioManager>().Play("walkSound");
    }

    void walkingSoundOff()
    {
        FindObjectOfType<audioManager>().Stop("walkSound");
    }
}
