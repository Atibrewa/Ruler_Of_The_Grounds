using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Battle Set Up", menuName ="Set Up")]
public class BattleSetUp : ScriptableObject
{
    public string bullyBattle;
    public bool peacefulEnding;
    
    public List<string> conqueredBattles;


    public void SetPeacefulEnding(bool ending) {
        peacefulEnding = ending;
    }

    public void SetBullyBattle(string name) {
        bullyBattle = name;
    }

    public void SetConqueredBattle(string battleName) {
        conqueredBattles.Add(battleName);
    }

    public List<string> ReturnConqueredBattles(){
        Debug.Log("returning list right now");
        return conqueredBattles;
    }
}
