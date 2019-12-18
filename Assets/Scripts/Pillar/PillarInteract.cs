using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarInteract : MonoBehaviour
{
    private bool active;

    private bool pillar1;
    private bool pillar2;
    private bool pillar3;
    void Start()
    {
        active = false;

        pillar1 = false;
        pillar2 = false;
        pillar3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        allActive();

        if (Input.GetKeyDown(KeyCode.Z))
        {
            pillar1 = true;
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            pillar2 = true;
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            pillar3 = true;
        }
        Debug.Log(active);


    }

    private void allActive()
    {
        if(pillar1 && pillar2 && pillar3)
        {
            active = true;
        }

        else
        {
            active = false;
        }
    }
}
