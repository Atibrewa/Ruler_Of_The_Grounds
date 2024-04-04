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

    private bool isMaxString = false;
    private Color textColor;

    // Letters Used: m, x, h, a, b, s, o
    private string[] possibleWords = {"bash", "abs", "baxom", "ox", "moss", "sham"};
    // Start is called before the first frame update
    void Start()
    {
        targetWord = possibleWords[Random.Range(0, possibleWords.Length)];
        reference.text = targetWord;
        GenerateSpaces();
        spelling.text = "";

        textColor = new Color32(93,22,0, 225);
        // textColor = Color.FromRgb(93, 22, 0);

    
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
        if (!isMaxString) {
            spelling.text += letter;
            if (targetWord.Length <= spelling.text.Length) {
                isMaxString = true;
                if (targetWord == spelling.text) {
                    // TODO: Add point
                    Debug.Log("Adding +1 point");
                    StartCoroutine(AnimateCorrect());
                }
                else {
                    Debug.Log("Did not the right word"); 
                    // TODO: Add visual indicator that the user didn't spell the right word
                    StartCoroutine(AnimateIncorrect());
                }
            // spelling.text = "";
        }

        }
        
    }

    public IEnumerator AnimateIncorrect() {
        spelling.color = Color.red;

        yield return new WaitForSeconds(2f);
        spelling.color = textColor;
        targetWord = possibleWords[Random.Range(0, possibleWords.Length)];
        spelling.text = "";
        GenerateSpaces();
               
        reference.text = targetWord;
        isMaxString = false;

    }

    public IEnumerator AnimateCorrect() {
        spelling.color = Color.green;

        yield return new WaitForSeconds(2f);
        spelling.color = textColor;
        targetWord = possibleWords[Random.Range(0, possibleWords.Length)];
        spelling.text = "";
        GenerateSpaces();
               
        reference.text = targetWord;
        isMaxString = false;
    }
}

