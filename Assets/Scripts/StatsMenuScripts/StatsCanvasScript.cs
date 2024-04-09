using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsCanvasScript : MonoBehaviour {

    public TMP_Text athleticsText;
    public TMP_Text reputationText;
    public TMP_Text languageText;
    public TMP_Text creativityText;
    public TMP_Text mathematicsText;
    public Statistics stats;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        athleticsText.SetText("Athletics: " + stats.athletics.ToString());
        reputationText.SetText("Reputation: " + stats.reputation.ToString());
        languageText.SetText("Language: " + stats.language.ToString());
        creativityText.SetText("Creativity: " + stats.creativity.ToString());
        mathematicsText.SetText("Math: " + stats.math.ToString());
    }

    public void GoBack() {
        gameObject.SetActive(false);
    }
}
