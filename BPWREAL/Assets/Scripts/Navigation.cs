using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    public NavMeshAgent navigation;
    public GameObject Target;

    void Update()
    {
        Navigation.destination = Target.transform.position; 
    }
}
