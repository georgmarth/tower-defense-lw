using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Creep : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        Agent.SetDestination(Target.position);
        
    }
}
