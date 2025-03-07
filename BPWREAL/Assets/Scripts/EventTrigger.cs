using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent unityEvent;
    public GameObject theTrigger;

    public void OnTriggerEnter(Collider other)
    {
            unityEvent.Invoke();
    }
}
