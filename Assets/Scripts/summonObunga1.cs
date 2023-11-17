using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonObunga1 : MonoBehaviour
{
    public GameObject obunga;
    public Collider collision;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            obunga.SetActive(true);
            collision.enabled = false;
        }
    }
}