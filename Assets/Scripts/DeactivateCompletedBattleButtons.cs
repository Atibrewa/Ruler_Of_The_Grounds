using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactivateCompletedBattleButtons : MonoBehaviour
{
    public BattleSetUp battles;

    public Button swingButton, minnieButton, sandcastleButton, seesawButton, structureButton;
    // Start is called before the first frame update
    void Start()
    {
        List<string> battlesList = battles.ReturnConqueredBattles();
        for (int i = 0; i < battlesList.Count; i++) {
            string battle = battlesList[i];
            if (battle.Contains("Swing")) {
                swingButton.enabled = false;
            }
            else if (battle.Contains("Minnie")) {
                minnieButton.enabled = false;
            }
            else if (battle.Contains("Sandcastle")) {
                sandcastleButton.enabled = false;
            }
            else if (battle.Contains("SeeSaw")) {
                seesawButton.enabled = false;
            }
            else if (battle.Contains("Structure")) {
                structureButton.enabled = false;

            }  
        }
    }

}
