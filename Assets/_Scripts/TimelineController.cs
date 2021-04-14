using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector director;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(director.state != PlayState.Playing)
            {
                director.Play();
            }
        }
    }

    public void DoSomethingWhenDoorOpen()
    {
        Debug.Log("abriu");
    }

    public void DoSomethingWhenCharacterShoot()
    {
        Debug.Log("Atirou");
    }
}
