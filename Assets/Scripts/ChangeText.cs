using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TMP_Text text;

    public void changeToText(string newText)
    {
        text.text = newText;
    }
}
