using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ReferenceTimer : MonoBehaviour
{
    // To be attached to a TextMesh Object thingy 
    public TextMeshProUGUI count;
    public TextMeshProUGUI directions;
    public int waitTime = 5;
    public AudioSource tick;

    public UnityEvent timerDone;


    // Start is called before the first frame update
    void Start()
    {
        count.text = "";
        StartCoroutine(Wait());
    }

    public IEnumerator Wait() {
        int seconds = waitTime;
        while (seconds > 0) {

            count.text = seconds.ToString();
            tick.Play(0);
            
            yield return new WaitForSeconds(1f);
            seconds -= 1;
            if (seconds == 0) {
                count.text = seconds.ToString();
                directions.text = "TIME'S UP!";
            }

        }
        yield return new WaitForSeconds(1f);
        count.text = "";

        timerDone.Invoke();
    }
}
