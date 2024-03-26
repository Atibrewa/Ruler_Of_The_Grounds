using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewSentence", menuName ="Dialogue/Sentence")]
public class Sentence : ScriptableObject
{
    [TextArea(3, 10)]
    public string text = "text";
    public Sentence nextSentence;

    public List<Choice> options = new List<Choice>();

    public bool HasOptions(){
        if (options.Count == 0){
            return false;
        }
        else{
            return true;
        }
    }

}

[System.Serializable]
public class Choice {
    [TextArea(3, 10)]
    public string text;
    public Sentence nextSentence;
    public GameEvent onOptionSelected;

}

