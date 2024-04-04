using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordSpeller : MonoBehaviour
{

    public TextMeshProUGUI spelling;
    public TextMeshProUGUI spaces;
    public TextMeshProUGUI reference;
    private string targetWord;

    // Letters Used: m, x, h, a, b, s, o
    private string[] possibleWords = {"bash", "abs", "baxom", "ox", "moss", "sham"};
    // Start is called before the first frame update
    void Start()
    {
        targetWord = possibleWords[Random.Range(0, possibleWords.Length)];
        reference.text = targetWord;
        GenerateSpaces();
        spelling.text = "";

    
    }

    private void GenerateSpaces() {
        spaces.text = "";
        for (int i = 0; i < targetWord.Length; i ++) {
            spaces.text += "_";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add(string letter) {
        spelling.text += letter;
        if (targetWord.Length <= spelling.text.Length) {
            if (targetWord == spelling.text) {
                // TODO: Add point
                Debug.Log("Adding +1 point");
                StartCoroutine(AnimateCorrect());
            }
            else {
                Debug.Log("Did not the right word"); 
                // TODO: Add visual indicator that the user didn't spell the right word
            }
            // spelling.text = "";
        }
    }

    public IEnumerator AnimateCorrect() {
        Debug.Log("AnimateCorrect() method called");
        yield return new WaitForSeconds(5f);

        targetWord = possibleWords[Random.Range(0, possibleWords.Length)];
        spelling.text = "";
        GenerateSpaces();
               
        reference.text = targetWord;
        Debug.Log("Done");
    }
}

