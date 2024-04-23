using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerDialogueBasedOnResults : MonoBehaviour
{
    public bool win;
    public UnityEvent winDialogue, loseDialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerDialogue() {
        if (win) {
            winDialogue.Invoke();
        }
        else {
            loseDialogue.Invoke();
        }
    }
}
