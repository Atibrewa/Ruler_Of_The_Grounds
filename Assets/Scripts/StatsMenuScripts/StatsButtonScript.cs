using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButtonScript : MonoBehaviour {

    public Canvas statsCanvas;

    // Start is called before the first frame update
    void Start() {
        statsCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void showStats() {
        statsCanvas.gameObject.SetActive(true);
    }
}
