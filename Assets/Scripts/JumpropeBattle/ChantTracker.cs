using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChantTracker : MonoBehaviour
{

    public TMP_Text chantText;
    public Statistics playerStat;

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
            
            yield return new WaitForSeconds(1f);
            index += 1;

        }
        yield return new WaitForSeconds(1f);
        // count.text = "";

        // timerDone.Invoke();
    }
}
