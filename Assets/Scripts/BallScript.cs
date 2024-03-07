using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public float startX;
    public float startY;

    // Start is called before the first frame update
    void Start() {
        ResetPos();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void ResetPos() {
        this.transform.position = new Vector3(startX, startY, 0);
    }

    public void OnPoint() {
        Invoke("ResetPos", 1f);
    }
}
