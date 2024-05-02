using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageCalculateScore : MonoBehaviour
{
    public WordSpeller speller;
    public TextMeshProUGUI scoreText;
    public Statistics playerStats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalculateScore() {
        // TODO: Add any calculations that should be done for this!
        int score = speller.score;
        scoreText.text = "Stat: +" + score.ToString();
        playerStats.UpdateStat("language", score);
        Debug.Log("Added to Language skills");

    }

}
