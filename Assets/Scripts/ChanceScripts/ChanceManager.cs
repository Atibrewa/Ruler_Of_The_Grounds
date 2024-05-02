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
        int chanceIndex = Random.Range (0, objects.Count);
        curEvent = objects[chanceIndex];
        text.text = curEvent.eventText;
        // imgSpot.sprite = curEvent.imgSprite;
        updateStats();
    }

    void Update()
    {
        // need to update this based on the final numbers of categories A-E
        // int rep = playerStats.reputation;
        // if (rep > 40) {
        //     upperLimit = 40;
        // } else if (rep > 30) {
        //     upperLimit = 35;
        // }
    }

    void updateStats()
    {
        playerStats.UpdateStat("athletics", curEvent.athletics);
        playerStats.UpdateStat("creativity", curEvent.creativity);
        playerStats.UpdateStat("language", curEvent.language);
        playerStats.UpdateStat("math", curEvent.math);
        playerStats.UpdateStat("reputation", curEvent.reputation);
    }
}
