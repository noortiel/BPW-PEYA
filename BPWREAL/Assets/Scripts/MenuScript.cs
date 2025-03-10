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
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}
