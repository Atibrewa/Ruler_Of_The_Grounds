using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerateResults : MonoBehaviour
{
    public BattleSetUp battle;
    public Statistics playerStats;
    public TextMeshProUGUI resultsText;

    private string playset;
    
    // Start is called before the first frame update
    void Start()
    {
        ChoosePlaysetName();
        if (battle.playerWin) {
            if (battle.peacefulEnding) {
                resultsText.text = "You've liberated the " + playset + "!";
            }
            else {
                resultsText.text = "You've conquered the " + playset + "!";
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChoosePlaysetName() {
        if (battle.bullyBattle.Contains("Swing")) {
            playset = "swings";
        }
        else if (battle.bullyBattle.Contains("Minnie")) {
            playset = "jumpropes";
        }
        else if (battle.bullyBattle.Contains("Sandcastle")) {
            playset = "sandbox";
        }
        else if (battle.bullyBattle.Contains("SeeSaw")) {
            playset = "seesaw";
        }

    }
}
