using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizeStuff : MonoBehaviour
{
    public GameObject thing1, thing2, thing3;
    int randNum;

    void Start()
    {
        randNum = Random.Range(0, 3);
        if (randNum == 0)
        {
            thing1.SetActive(true);
        }
        if (randNum == 1)
        {
            thing2.SetActive(true);
        }
        if (randNum == 2)
        {
            thing3.SetActive(true);
        }
    }
}