﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousemovement : MonoBehaviour
{
    
    [SerializeField]
    private int rotationSpeed = 100;
    void Start()
    {
        Cursor.visible = false;
    }
   
    void Update()
    {
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;
              rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.fixedDeltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
