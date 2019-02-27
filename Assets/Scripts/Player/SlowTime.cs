using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SlowTime : MonoBehaviour
{
    // Toggles the time scale between 1 and 0.7
    // whenever the user hits the Fire1 button.

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Time.timeScale = 0.5f;
        }
        else
        {
            Time.timeScale = 1.0f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }


        // Adjust fixed delta time according to timescale
        // The fixed delta time will now be 0.02 frames per real-time second
        

    }

}   