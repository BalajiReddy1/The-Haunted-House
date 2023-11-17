using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaryEventTrigger : MonoBehaviour
{
    public GameObject scare;
    public AudioSource scareSound;
    public Collider collision;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scare.SetActive(true);
            //scareSound.Play();
            collision.enabled = false;
        }
    }
}