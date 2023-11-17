using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepSounds : MonoBehaviour
{
    public AudioSource footstepswalk, footstepssprint;
    public bool sprinting;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sprinting = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                sprinting = false;
            }
            if (sprinting == true)
            {
                footstepswalk.enabled = false;
                footstepssprint.enabled = true;
            }
            if (sprinting == false)
            {
                footstepswalk.enabled = true;
                footstepssprint.enabled = false;
            }
        }
        else
        {
            footstepswalk.enabled = false;
            footstepssprint.enabled = false;
            sprinting = false;
        }
    }
}