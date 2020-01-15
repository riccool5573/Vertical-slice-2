using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBreath : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem fire;
    [SerializeField]
    private Collider FireHB;
    void Update()
    {
        fire.maxParticles = 0;
        FireHB.enabled = false;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            FireHB.enabled = true;
            fire.maxParticles = 50;
        }
    }
}
