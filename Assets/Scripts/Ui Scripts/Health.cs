using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthBar;
    private int hp;

    private int dmg = 10;
    void Start()
    {
        hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = hp;
        TakeDamage();
    }

    private void TakeDamage()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            hp = hp - dmg;
        }
    }
}
