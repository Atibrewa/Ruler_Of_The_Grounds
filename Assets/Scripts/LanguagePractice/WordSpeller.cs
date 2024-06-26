using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordSpeller : MonoBehaviour
{
    public TextMeshProUGUI spelling;
    public TextMeshProUGUI spaces;
    public TextMeshProUGUI reference;
    public TextMeshProUGUI scoreText;
    private string targetWord;

    private bool isMaxString = false;
    private Color textColor;
    public int score = 0;

    public AudioSource clickSound;
    // Letters Used: m, x, h, a, b, s, o
    // Roughly ~51 words
    private string[] possibleWords = {
        "beat", "bat", "bet", "best", "bad", "bade", "box", "bot", "bob", "boe", "boa", "boss", "bass", "beet", "bee", "bed", "bats", 
        "tea", "tee", "tax", "tab", "tad", "ted", "test", "toss", "tabs", "text", "oat", "ox", "odd", "ode", "ate", "abs", "add",
        "boat", "eat", "east", "dad", "dab", "do", "date", "dead", "boot", "sod", "sad", "soda", "seed", "sat", "seat", "sob", "sod",
        "see", "sea", "set", "so"
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
        clickSound.Play();
        if (!isMaxString) {
            spelling.text += letter;
            if (targetWord.Length <= spelling.text.Length) {
                isMaxString = true;
                if (targetWord == spelling.text) {
                    score += 1;
                    StartCoroutine(AnimateCorrect());
                }
                else {
                    // score -= 1;
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

        UpdateScore();
    }

    public void UpdateScore() {
        scoreText.text = "Score: " + score.ToString();
    }
}

