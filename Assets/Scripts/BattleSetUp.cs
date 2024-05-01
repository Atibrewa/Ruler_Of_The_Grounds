using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Battle Set Up", menuName ="Set Up")]
public class BattleSetUp : ScriptableObject
{
    public string bullyBattle;
    public bool peacefulEnding;
    public bool playerWin;

   

    public void SetPeacefulEnding(bool ending) {
        peacefulEnding = ending;
    }

    public void SetPlayerWin(bool win) {
        playerWin = win;
    }

    public void SetBullyBattle(string name) {
        bullyBattle = name;
    }

    public void SetDialogueTree() {

    }
}
