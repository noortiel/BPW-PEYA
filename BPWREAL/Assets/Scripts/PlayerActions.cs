using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Transform camera;
    public float playerActivateDistance;
    bool active = false;

    private void Update() {
        RaycastHit hit;
        active = Physics.Raycast(camera.position, camera.TransformDirection(Vector3.forward), out hit, playerActivateDistance);
   
    if(Input.GetKeyDown(KeyCode.E) && active == true)
        {
            if(hit.transform.GetComponent<Animator>() != null)
            {
                hit.transform.GetComponent<Animator>().SetTrigger("Activate");
            }
        }
    
    }

}
