using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

    private int score;
    public TMP_Text text;

    public GameObject popup;
    public TMP_Text scoreLabel;

    public Statistics stats;

    // Start is called before the first frame update
    void Start() {
        score = 0;
        text.text = "0";
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        text.text = score.ToString();
    }

    public void Point() {
        score++;
    }

    public void TimesUp() {
        int statUpdate = score/2;
        scoreLabel.SetText("Stat: +" + statUpdate);
        popup.SetActive(true);
        stats.athletics+= statUpdate;
    }
}
