using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject CutsceneCamera;
   private void OnTriggerStay(Collider rightSide)
    {

       CutsceneCamera.SetActive(false);
        
       SceneManager.LoadScene("MainMenu");
       Cursor.lockState = CursorLockMode.None;
        
    }

}
