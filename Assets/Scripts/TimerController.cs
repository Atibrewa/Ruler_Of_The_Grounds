using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TimerController : MonoBehaviour {
    public float time = 30f;
    public TMP_Text text;

    public UnityEvent timesUp;

    // Start is called before the first frame update
    void Start() {
        text.SetText(time.ToString());
        Invoke("StartTime", 1);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void StartTime() {
        StartCoroutine(Time());
    }

    IEnumerator Time() {
        while (time > 0) {
            time--;
            text.SetText(time.ToString());
            Debug.Log(time.ToString());
            if (time == 0) {
                timesUp.Invoke();
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
