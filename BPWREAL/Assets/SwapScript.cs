using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapScript : MonoBehaviour
{
    public bool swap;

    public PlayerMovementTutorial playerMov1;
    public GameObject cam1;
    public PlayerMovementTutorial playerMov2;
    public GameObject cam2;

    // private KeyCode switchKey = KeyCode.LeftShift;
    
    void Start()
    {
        swap = true;

        playerMov1.active = false;
        cam1.active = false;
    }

    
    void Update()
    {
        


        // when to swap
        if (Input.GetKeyDown(KeyCode.LeftShift) && swap == true)
        {
            swap = false;
            playerMov1.active = true;
            cam1.active = true;
            
            playerMov2.active = false;
            cam2.active = false;
            return;

        }

        else if (Input.GetKeyDown(KeyCode.LeftShift) && swap == false)
        {
            swap = true;
            playerMov2.active = true;
            cam2.active = true;
           
            playerMov1.active = false;
            cam1.active = false;
        }
    }
}
