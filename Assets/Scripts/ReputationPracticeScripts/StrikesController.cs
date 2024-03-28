using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StrikesController : MonoBehaviour {

    int strikes;
    public int maxStrikes;

    // Start is called before the first frame update
    void Start() {
        strikes = 0;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void AddStrike() {
        strikes += 1;
        GetComponent<TMP_Text>().SetText("Strikes: " + strikes);
    }
}
