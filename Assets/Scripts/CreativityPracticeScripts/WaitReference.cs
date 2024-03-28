using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaitReference : MonoBehaviour
{
    public TextMeshProUGUI count;
    public int waitTime;
    public GameEventListener listener;
    public GameEvent finished;

    private Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
        count.text = "";

    }

    public IEnumerator Wait() {
        int seconds = 0;

        while (seconds <= waitTime) {
            count.text = seconds.ToString();
            Debug.Log("Seconds: "+ seconds);
            yield return new WaitForSeconds(1f);
            seconds += 1;

        }

        count.text = "TIME'S UP!";
        HideChildren();

        yield return new WaitForSeconds(1f);
        count.text = "";
        finished.Raise();
    }

    public void RevealChildren() {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);

        StartCoroutine(Wait());
    }

    private void HideChildren() {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }
}
