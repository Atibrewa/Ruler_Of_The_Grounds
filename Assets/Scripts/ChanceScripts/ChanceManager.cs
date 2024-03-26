using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChanceManager : MonoBehaviour
{
    public List<ChanceObject> objects;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        int chanceIndex = Random.Range (1,(objects.Count - 1));
        ChanceObject curEvent = objects[chanceIndex];
        text.text = curEvent.eventText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
