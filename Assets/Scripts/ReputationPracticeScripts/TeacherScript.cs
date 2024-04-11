using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TeacherScript : MonoBehaviour {

    public float min_seconds;
    public float max_seconds;
    bool gameOver;
    bool isLooking;

    public GameObject thought_bubble;

    public UnityEvent startLooking;
    public UnityEvent stopLooking;

    Animator animator;

    // Start is called before the first frame update
    void Start() {
        thought_bubble.SetActive(false);
        gameOver = false;
        isLooking = false;
        animator = GetComponent<Animator>();
        animator.Play("TeacherAnimation");
        TeachCycle();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void TeachCycle() {
        float secs = Random.Range(min_seconds, max_seconds);
        Debug.Log(secs);
        if (!gameOver) {
            StartCoroutine(Look(secs));
        }
    }

    IEnumerator Look(float secs) {
        yield return new WaitForSeconds(secs);
        thought_bubble.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        isLooking = true;
        Look_Animate();
        startLooking.Invoke();
        thought_bubble.SetActive(false);
        yield return new WaitForSeconds(1f);
        isLooking = false;
        Look_Animate();
        stopLooking.Invoke();
        TeachCycle();
    }

    void Look_Animate() {
        if (isLooking) {
            animator.Play("TeacherLook");
        }
        else {
            animator.Play("TeacherAnimation");
        }
    }

    public void GameOver() {
        gameOver = true;
    }
}
