using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AppliedPaintAnimator : MonoBehaviour
{
    public UnityEvent finishedPaintingEvent;
    public GameObject painter; 

    void Start() {
    }

    // This C# function can be called by an Animation Event
    public void PrintFloat (float theValue) {
        Debug.Log ("ANIMATION ENDED WOOT");
        finishedPaintingEvent.Invoke();
    }

}