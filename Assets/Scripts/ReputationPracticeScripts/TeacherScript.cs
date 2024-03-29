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

    public GameObject thought_bubble;

    public UnityEvent startLooking;
    public UnityEvent stopLooking;

    // Start is called before the first frame update
    void Start() {
        thought_bubble.SetActive(false);
        gameOver = false;
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
        Look_Animate();
        startLooking.Invoke();
        thought_bubble.SetActive(false);
        yield return new WaitForSeconds(1f);
        Look_Animate();
        stopLooking.Invoke();
        TeachCycle();
    }

    void Look_Animate() {
        Debug.Log("in Look_Animate");
        Vector3 scale = transform.localScale;
        float scaleX = scale.x;
        scale.x = -scaleX;
        transform.localScale = scale;
    }

    public void GameOver() {
        gameOver = true;
    }
}
