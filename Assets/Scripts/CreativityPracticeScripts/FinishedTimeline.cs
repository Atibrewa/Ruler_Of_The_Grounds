using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

public class FinishedTimeline : MonoBehaviour
{
    public PlayableDirector director; 
    public UnityEvent triggerEvent;
    private bool notTriggered = true;

    // Update is called once per frame
    void Update()
    {
        if (director.state != PlayState.Playing && notTriggered) {
            notTriggered = false;
            triggerEvent.Invoke();
        }
    }
}
