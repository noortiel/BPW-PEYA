using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    private void OnTriggerStay(Collider other)
    {
        
             myAnimationController.SetBool("IsTriggered", true);
            Debug.Log("Triggered");
        
    }
}
