using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour
{
    public DialogueTree dialogue;
    public DialogueManager dialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        dialogueManager.StartDialogue(dialogue);
    }
}
