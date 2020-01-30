using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    private int attackStance;

    private bool attack1;
    private bool attack2;
    private bool attack3;

    private bool atkButtonPressed;
    float currCountdownValue;

    void Start()
    {
        attackStance = 0;

        attack1 = false;
        attack2 = false;
        attack3 = false;
        atkButtonPressed = false;

    }

    // Update is called once per frame
    void Update()
    {
        CombatCycle();

        if (Input.GetKeyDown(KeyCode.S))
        {
            atkButtonPressed = true;
            StartCoroutine(StartCountdown());
            Debug.Log(atkButtonPressed);
        }

        Debug.Log("atk stance = " + attackStance);
        Debug.Log("atk1 = " + attack1);
        Debug.Log("atk2 = " + attack2);
        Debug.Log("atk3 = " + attack3);
    }

    private void CombatCycle()
    {
        if (currCountdownValue <= 0)
        {
            attackStance = 0;
        }

        if (attackStance == 0 && atkButtonPressed)
        {
            attackStance = 1;
            atkButtonPressed = false;
        }

        else if (attackStance == 1 && atkButtonPressed)
        {
            attackStance = 2;
            atkButtonPressed = false;
        }

        else if (attackStance == 2 && atkButtonPressed)
        {
            attackStance = 3;
            atkButtonPressed = false;
        }

        else if (attackStance == 3 && !atkButtonPressed)
        {
            attackStance = 0;
        }

        switch (attackStance)
        {
            case 0:
                attack1 = false;
                attack2 = false;
                attack3 = false;
                break;

            case 1:
                attack1 = true;
                attack2 = false;
                attack3 = false;
                break;

            case 2:
                attack1 = false;
                attack2 = true;
                attack3 = false;
                break;

            case 3:
                attack1 = false;
                attack2 = false;
                attack3 = true;
                break;

            default:
                attack1 = false;
                attack2 = false;
                attack3 = false;
                break;
        }

        
    }

  
    public IEnumerator StartCountdown(float countdownValue = 2)
    {
        
        currCountdownValue = countdownValue;

        if (Input.GetKeyDown(KeyCode.S))
        {
            while (currCountdownValue > 0)
            {
                Debug.Log("Countdown: " + currCountdownValue);
                yield return new WaitForSeconds(1.0f);
                currCountdownValue--;
            }
        }
    }
}
