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
    public int score = 0;

    // Letters Used: m, x, h, a, b, s, o
    private string[] possibleWords = {
        "bash", "abs", "baxom", "ox", "moss", "sham", "ham", "mam", "hash", "sos", "shoo", "shab", "ooh", "hoo", "soso", "bass", "box", 
        "max", "mooh", "sass", "oxo", "hobo", "hobb", "bobb", "hax", "ash", "hash", "mash", "sash", "hoam", "hamo", "bama", "sho", "abos",
        "xox", "hoax", "moax", "sxo", "omo", "boo", "xoo", "moo", "hosh", "mama", "habs", "haso", "saho", "soho", "boho", "bobo", "bahm"
        };
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
                    score += 1;
                    StartCoroutine(AnimateCorrect());
                }
                else {
                    score -= 1;
                    StartCoroutine(AnimateIncorrect());
                }
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

