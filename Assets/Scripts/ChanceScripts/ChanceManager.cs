using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChanceManager : MonoBehaviour
{
    public List<ChanceObject> objects;
    public TMP_Text text;
    public Statistics playerStats;
    private ChanceObject curEvent;

    // Start is called before the first frame update
    void Start()
    {
        int chanceIndex = Random.Range (1,(objects.Count - 1));
        curEvent = objects[chanceIndex];
        text.text = curEvent.eventText;
        updateStats();
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
