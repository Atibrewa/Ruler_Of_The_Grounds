using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageButtonClick : MonoBehaviour
{
    public string letter;
    public WordSpeller speller;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown(){
        speller.Add(letter);
    }
}
