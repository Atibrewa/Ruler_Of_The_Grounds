using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BasketScript : MonoBehaviour {

public UnityEvent Point;

private bool timesUp;

    // Start is called before the first frame update
    void Start() {
        timesUp = false;
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Ball") && !timesUp) {
            Point.Invoke();
        }
    }

    public void TimeUp() {
        timesUp = true;
    }
}
