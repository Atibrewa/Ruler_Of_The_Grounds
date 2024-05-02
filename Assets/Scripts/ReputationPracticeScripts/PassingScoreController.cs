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
    bool mouseDown;
    bool animating;
    public TMP_Text text;
    public GameObject passingPaper;
    public float mercyTime;
    public UnityEvent getStrike;
    public Statistics stats;
    Animator animator;

    public GameObject popup;
    public TMP_Text scoreLabel;

    void Start() {
        score = 0f;
        inMercy = false;
        gameOver = false;
        mouseDown = false;
        animating = false;
        popup.SetActive(false);
        animator = passingPaper.GetComponent<Animator>();
        animator.Play("StudentSit");
        StopLooking();
    }

    // Update is called once per frame
    void Update() {
        if (!isLooking && Input.GetMouseButton(0) && !gameOver) {
            score += 0.01f;
            mouseDown = true;
            Animate();
        }
        if (isLooking && Input.GetMouseButton(0) && !inMercy) {
            getStrike.Invoke();
            inMercy = true;
            Invoke("MercyTimer",mercyTime);
        }
        if (!Input.GetMouseButton(0)) {
            mouseDown = false;
            Animate();
        }
        text.SetText(Math.Floor(score).ToString());
    }

    public void StartLooking() {
        isLooking = true;
    }

    public void StopLooking() {
        isLooking = false;
    }


    void MercyTimer() {
        inMercy = false;
    }

    public void GameOver() {
        gameOver = true;
        int statUpdate = (int)score/4;
        scoreLabel.SetText("Stat: +" + statUpdate);
        stats.reputation += statUpdate;
        popup.SetActive(true);
    }

    void Animate() {
        if (mouseDown & !animating) {
            animator.Play("StudentAnimator");
            animating = true;
        }
        else if (animating & !mouseDown) {
            animator.Play("StudentSit");
            animating = false;
        }
    }
}
