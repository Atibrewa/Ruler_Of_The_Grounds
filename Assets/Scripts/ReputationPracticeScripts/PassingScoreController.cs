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
    public GameObject passingPaper;

    void Start() {
        score = 0f;
        StopLooking();
    }

    // Update is called once per frame
    void Update() {
        if (!isLooking && Input.GetMouseButton(0)) {
            score += 0.01f;
            StartCoroutine("AnimatePassing");
        }
        text.SetText(Math.Floor(score).ToString());
    }

    public void StartLooking() {
        isLooking = true;
    }

    public void StopLooking() {
        isLooking = false;
    }

    IEnumerator AnimatePassing() {
        Vector3 scale = passingPaper.transform.localScale;
        scale.y = scale.y * -1;
        passingPaper.transform.localScale = scale;
        yield return new WaitForSeconds(0.3f);
    }
}
