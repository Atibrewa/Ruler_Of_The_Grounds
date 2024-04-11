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

    public UnityEvent startGame;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
        count.text = "";
        StartCoroutine(Wait());
        Debug.Log("Start finished");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Wait() {
        Debug.Log("Called Wait() for timer");
        int seconds = waitTime;

        while (seconds > 0) {

            count.text = seconds.ToString();

            
    
            Debug.Log(seconds);
            yield return new WaitForSeconds(1f);
            seconds -= 1;
            if (seconds == 0) {
                count.text = seconds.ToString();
                directions.text = "TIME'S UP!";
            }

        }
        yield return new WaitForSeconds(1f);
        count.text = "";

        startGame.Invoke();
    }
}
