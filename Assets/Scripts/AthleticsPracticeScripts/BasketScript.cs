using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BasketScript : MonoBehaviour {

public UnityEvent Point;
public float leftXBound;
public float rightXBound;

private bool timesUp;

    // Start is called before the first frame update
    void Start() {
        timesUp = false;
        RandomPosition();
    }

    // Update is called once per frame
    void Update() {
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Ball") && !timesUp) {
            Point.Invoke();
            Invoke("RandomPosition", 1f);
        }
    }

    public void TimeUp() {
        timesUp = true;
    }

    public void RandomPosition() {
        float randX = Random.Range(leftXBound, rightXBound);
        Debug.Log(randX.ToString());
        float y = this.transform.position.y;
        this.transform.position = new Vector3(randX, y, 0);
    }
}
