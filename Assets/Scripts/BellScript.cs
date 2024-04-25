using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellScript : MonoBehaviour {
    // Start is called before the first frame update

    public Animator animator;
    AudioSource audio;

    bool ringing = false;

    void Start() {
        audio = GetComponent<AudioSource>();
        if (ringing) {
            Debug.Log("Ringing");
            audio.Play();
            animator.Play("BellRingAnimation");
        }
        else {
            Debug.Log("Not Ringing");
            animator.Play("BellNotRing");
        }
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Ring() {
        ringing = true;
    }
}
