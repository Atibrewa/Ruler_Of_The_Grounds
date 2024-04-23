using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Battle Set Up", menuName ="Set Up")]
public class BattleSetUp : ScriptableObject
{
    public string bullyBattle;

   

    // // Start is called before the first frame update
    // public void StartBattleScene()
    // {
    //     if (bullyBattle.Contains("Swing")) {
    //         SwingBattle.SetActive(true);
    //     }
        
    // }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBullyBattle(string name) {
        bullyBattle = name;
    }

    public void SetDialogueTree() {

    }
}
