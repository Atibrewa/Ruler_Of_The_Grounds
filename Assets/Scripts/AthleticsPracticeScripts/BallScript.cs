using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public float startX;
    public float startY;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start() {
        ResetPos();
        audioSource = GetComponent<AudioSource>();
        audioSource.time = 0.07f;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void ResetPos() {
        transform.position = new Vector3(startX, startY, 0);
    }

    public void OnPoint() {
        Invoke("ResetPos", 1f);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        audioSource.volume = collision.relativeVelocity.magnitude/100;
        audioSource.Play();
    }
}
