using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FinishedTimeline : MonoBehaviour
{
    public PlayableDirector director; 
    public GameEvent triggerEvent;
    private bool notTriggered = true;

    // Update is called once per frame
    void Update()
    {
        if (director.state != PlayState.Playing && notTriggered) {
            Debug.Log("We finished the timeline!");
            notTriggered = false;
            triggerEvent.Raise();
        }
    }
}
