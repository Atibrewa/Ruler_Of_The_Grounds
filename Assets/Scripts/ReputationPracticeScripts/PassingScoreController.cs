using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PassingScoreController : MonoBehaviour {
    // Start is called before the first frame update

    float score;
    bool isLooking;
    bool inMercy;
    bool gameOver;
    public TMP_Text text;
    public GameObject passingPaper;
    public float mercyTime;
    public UnityEvent getStrike;

    void Start() {
        score = 0f;
        StopLooking();
        inMercy = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update() {
        if (!isLooking && Input.GetMouseButton(0) && !gameOver) {
            score += 0.01f;
            StartCoroutine("AnimatePassing");
        }
        if (isLooking && Input.GetMouseButton(0) && !inMercy) {
            getStrike.Invoke();
            inMercy = true;
            Invoke("MercyTimer",mercyTime);
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

    void MercyTimer() {
        inMercy = false;
    }

    public void GameOver() {
        gameOver = true;
    }
}
