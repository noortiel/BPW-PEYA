using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    public PlayerActions doorAnim;
    private void Start()
    {
        doorAnim.gameObject.GetComponent<PlayerActions>().enabled = false;  
    }
    

    
    private void OnTriggerStay(Collider rightSide)
    {
        doorAnim.gameObject.GetComponent<PlayerActions>().enabled = true;

    }
}
