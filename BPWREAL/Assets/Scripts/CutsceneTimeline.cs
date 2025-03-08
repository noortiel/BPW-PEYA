using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTimeline : MonoBehaviour
{
    [SerializeField] PlayableDirector director;
    

    public void StartCutsceneTimeline()
    {
        director.Play();

    }
}
