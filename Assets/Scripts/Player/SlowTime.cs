using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SlowTime : MonoBehaviour
{
    private bool timeSlowed = false;
 
    void Update()
    {

        if (Input.GetButtonDown("Fire2"))
        {
            timeSlowed = !timeSlowed; // toggles onoff at each click

            if (timeSlowed)
            {
                Time.timeScale = 0.15f;
            }
            else
            {
                Time.timeScale = 1.0f;
            }
        }
    }
}
