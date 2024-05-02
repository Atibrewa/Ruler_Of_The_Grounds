using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChanceManager : MonoBehaviour
{
    public List<ChanceObject> objects;
    public TMP_Text text;
    public Statistics playerStats;
    public Image imgSpot;
    private ChanceObject curEvent;
    private int upperLimit;

    // Start is called before the first frame update
    void Start()
    {
        setIndex();
        int chanceIndex = Random.Range (0, upperLimit);
        curEvent = objects[chanceIndex];
        text.text = curEvent.eventText;
        // imgSpot.sprite = curEvent.imgSprite;
        updateStats();
    }

    private void setIndex() 
    {
        int rep = playerStats.reputation;
        if (rep > 40) {
            upperLimit = 35;
        } else if (rep > 30) {
            upperLimit = 30;
        } else if (rep > 20) {
            upperLimit = 24;
        } else if (rep > 10) {
            upperLimit = 16;
        } else {
            upperLimit = 9;
        }
    }

    private void updateStats()
    {
        playerStats.UpdateStat("athletics", curEvent.athletics);
        playerStats.UpdateStat("creativity", curEvent.creativity);
        playerStats.UpdateStat("language", curEvent.language);
        playerStats.UpdateStat("math", curEvent.math);
        playerStats.UpdateStat("reputation", curEvent.reputation);
    }
}
