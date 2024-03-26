using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikesController : MonoBehaviour {

    SpriteRenderer sRenderer;

    // Start is called before the first frame update
    void Start() {
        sRenderer = this.GetComponent<SpriteRenderer>();
        sRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void AddStrike() {
        sRenderer.enabled = true;
    }
}
