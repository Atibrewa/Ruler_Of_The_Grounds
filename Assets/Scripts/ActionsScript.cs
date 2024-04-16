using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActionsScript : MonoBehaviour {

    TMP_Text text;

    public Statistics stats;

    // Start is called before the first frame update
    void Start() {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update() {
        text.SetText("Actions: " + stats.actions + "/2");
    }
}
