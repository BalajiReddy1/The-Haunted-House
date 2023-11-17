using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserSwitch : MonoBehaviour
{
    public Animator switchAnim;
    public GameObject lasers, intText;
    public bool interactable, toggle;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (toggle == false)
            {
                intText.SetActive(true);
                interactable = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                switchAnim.SetTrigger("pull");
                lasers.SetActive(false);
                intText.SetActive(false);
                toggle = true;
                interactable = false;
            }
        }
    }
}
