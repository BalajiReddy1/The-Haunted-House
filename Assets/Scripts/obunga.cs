using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class obunga : MonoBehaviour
{
    public NavMeshAgent ai;
    public Transform player;
    Vector3 dest;

    void Update()
    {
        dest = player.position;
        ai.destination = dest;
    }
}