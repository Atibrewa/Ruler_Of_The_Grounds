using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupScript : MonoBehaviour {

    public GameObject button;
    // Start is called before the first frame update
    void Start() {
        gameObject.SetActive(false);
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void GameOver() {
        gameObject.SetActive(true);
        button.SetActive(true);
    }
}
