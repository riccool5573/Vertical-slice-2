using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlow : MonoBehaviour
{
    // Start is called before the first frame update
    private bool cooldown = true;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1;
        if (Input.GetKey(KeyCode.Mouse1))
        {
            
            if (cooldown)
            {
                Debug.Log("ZA WARUDO");
                StartCoroutine(TimeStop());
            }
        }
    }
    IEnumerator TimeStop()
    {
        cooldown = false;
        Time.timeScale = 0.50f;
        Debug.Log("ZA WARUDO");
        yield return new WaitForSecondsRealtime(5);
        Debug.Log("ZA WARUDO");
        Time.timeScale = 1;
        cooldown = true;
    }
}
