using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PassingScoreController : MonoBehaviour {
    // Start is called before the first frame update

    float score;
    Boolean isLooking;
    public TMP_Text text;

    void Start() {
        score = 0f;
        stopLooking();
    }

    // Update is called once per frame
    void Update() {
        if (!isLooking && Input.GetMouseButton(0)) {
            score += 0.01f;
        }
        text.SetText(Math.Floor(score).ToString());
    }

    public void startLooking() {
        isLooking = true;
    }
    public void stopLooking() {
        isLooking = false;
    }
}
