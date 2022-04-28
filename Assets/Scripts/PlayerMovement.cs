using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public Transform destinationTransform;
    public float Speed;
    
    void Start()
    {
        
    }

    void Update()
    {
        NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent> ();
        navMeshAgent.destination = destinationTransform.position;
        navMeshAgent.speed = Speed;
    }
}
