using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ChantTracker : MonoBehaviour
{

    public TMP_Text chantText;
    public Statistics playerStat;
    public UnityEvent jumpDone, pantDone, winEvent, loseEvent;

    private int index = 0;
    private int endIndex = 0;
    private string[] alphabet = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S"};

    // Start is called before the first frame update
    void Start()
    {
        if (playerStat.reputation >= 10 && playerStat.language >= 10) {
            endIndex = 19;
        }
        else {
            endIndex = 13;
        }
        StartCoroutine(ChantLetters());
        
    }

    // Update is called once per frame
    void Update()
    {
        // wait 0.5 seconds 
        // chantText.text = alphabet[index];
        // index += 1;

    }

    public IEnumerator ChantLetters() {
        while (index < endIndex) {
            Debug.Log("running");
            chantText.text = alphabet[index];
            // tick.Play(0);
            
            yield return new WaitForSeconds(0.8f);
            index += 1;

        }
        // count.text = "";
        yield return new WaitForSeconds(0.1f);

        jumpDone.Invoke();

        yield return new WaitForSeconds(1.5f);

        Debug.Log("printed after 1 second");
        pantDone.Invoke();

        if (endIndex < 19) {
            // lose
            loseEvent.Invoke();
        }
        else {
            // win
            winEvent.Invoke();
        }

    }
}
