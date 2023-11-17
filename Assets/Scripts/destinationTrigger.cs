using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destinationTrigger : MonoBehaviour
{
    public Collider collision;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("monster"))
        {
            StartCoroutine(reEnable());
            collision.enabled = false;
        }
    }
    IEnumerator reEnable()
    {
        yield return new WaitForSeconds(6.0f);
        collision.enabled = true;
    }
}