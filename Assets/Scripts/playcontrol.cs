using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private ParticleSystem fire;
    [SerializeField]
    private Collider FireHB;
    [SerializeField]
    private Animator anim;
    PlayerController controls;
    private Rigidbody rb;
    public bool isGrounded;
    public bool isInTheAir = false;
    public int jumpHeight;
    private bool doubleJump = false;
    Vector2 move;
    float breath;
    private int sprint = 1;
    private bool cooldown = true;
    
    void Awake()
    {
        controls = new PlayerController();
        rb = GetComponent<Rigidbody>();
        controls.GamePlay.Jump.performed += ctx => Jump();
        controls.GamePlay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GamePlay.Move.canceled += ctx => move = Vector2.zero;
        controls.GamePlay.Breath.performed += ctx => breath = ctx.ReadValue<float>();
        controls.GamePlay.Breath.performed += ctx => fireAttackSoundOn();
        controls.GamePlay.Breath.canceled += ctx => breath = 0;
        controls.GamePlay.Breath.canceled += ctx => fireAttackSoundOff();
        controls.GamePlay.TimeSlow.performed += ctx => StartCoroutine(TimeStop());
        controls.GamePlay.Sprint.performed += ctx => sprint = 2;
        controls.GamePlay.Sprint.canceled += ctx => sprint = 1;
    }
    void Update()
    {
        Debug.Log(anim.GetBool("jump"));
        Vector3 M = new Vector3(move.x,0,move.y) * Time.fixedDeltaTime * 10;
        if(move.x > 0f || move.y > 0f && isGrounded)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
            
        }
        transform.Translate(M * sprint,  Space.Self);
        fire.maxParticles = 0;
        FireHB.enabled = false;
        Debug.Log(breath);       
        if (breath >= 1)
        {           
            FireHB.enabled = true;
            fire.maxParticles = 100;
            anim.SetBool("fire", true);
            
        }
        else
        {
            anim.SetBool("fire", false);
           
        }
    
        }
   
    // om ervoor te zorgen dat je firebreath geluid maakt moet je deze functions ff ergens in stoppen.
void fireAttackSoundOn()
    {
        FindObjectOfType<audioManager>().Play("fireAttack");
    }

    void fireAttackSoundOff()
    {
        FindObjectOfType<audioManager>().Stop("fireAttack");
    }

    IEnumerator TimeStop()
    {
        cooldown = false;
        Time.timeScale = 0.50f;
        Debug.Log("ZA WARUDO");
       
        yield return new WaitForSecondsRealtime(5);
        Time.timeScale = 1;
        cooldown = true;
    }
   
    void Jump()
    {
         if (isGrounded)
        {
            
           
                rb.velocity = new Vector3(rb.velocity.z, jumpHeight);
                isGrounded = false;
                isInTheAir = true;
                rb.drag = 0;
                doubleJump = true;
                anim.SetBool("jump", true);

        }

        else if (!isGrounded && isInTheAir)
        {
           
                rb.velocity = new Vector3(rb.velocity.z, jumpHeight);
                isInTheAir = false;
                doubleJump = false;
            anim.SetBool("dubblejump", true);




        }  
        else if(!isGrounded && !doubleJump)
        {
            gliding();
        }
        
    }
    void OnEnable()
    {
        controls.GamePlay.Enable();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
            isInTheAir = false;
            anim.SetBool("jump", false);
            anim.SetBool("dubblejump", false);

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
