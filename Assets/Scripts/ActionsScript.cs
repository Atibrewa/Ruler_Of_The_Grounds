using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ActionsScript : MonoBehaviour {

    TMP_Text text;

    public Statistics stats;

    public UnityEvent recessTime;
    public UnityEvent toPlayground;

    // Start is called before the first frame update
    void Start() {
        text = GetComponent<TMP_Text>();
        if (stats.actions >= 2) {
            StartCoroutine(EndClass());
        }
    }

    // Update is called once per frame
    void Update() {
        text.SetText("Actions: " + stats.actions + "/2");
    }

    IEnumerator EndClass() {
        recessTime.Invoke();
        Debug.Log("Recess Time");
        yield return new WaitForSecondsRealtime(1f);
        Debug.Log("To Playground");
        stats.actions = 0;
        toPlayground.Invoke();
    }

    
}
