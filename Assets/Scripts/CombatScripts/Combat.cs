using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    private Jump jump;

    private int isAttacking = 0;

    private bool atkPhase1;
    private bool atkPhase2;
    private bool atkPhase3;
    void Start()
    {
        jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        AttackPhases();

        Debug.Log(isAttacking);
    }

    private void AttackPhases()
    {
        switch (isAttacking)
        {
            case 0:
                atkPhase1 = false;
                atkPhase2 = false;
                atkPhase3 = false;

                if (Input.GetKeyDown(KeyCode.K))
                {
                    isAttacking = 1;
                }
                //Don't attack
                break;

            case 1:
                atkPhase1 = true;
                atkPhase2 = false;
                atkPhase3 = false;
                if (Input.GetKeyDown(KeyCode.K) && atkPhase1)
                {
                    isAttacking = 2;
                }
                break;

            case 2:
                atkPhase1 = false;
                atkPhase2 = true;
                atkPhase3 = false;
                if (Input.GetKeyDown(KeyCode.K) && atkPhase2)
                {
                    isAttacking = 3;
                }
                break;

            case 3:
                atkPhase1 = false;
                atkPhase2 = false;
                atkPhase3 = true;

                if (atkPhase3)
                {
                    isAttacking = 0;
                }
                break;


            default:
                //Idle
                break;
        }
    }
}
