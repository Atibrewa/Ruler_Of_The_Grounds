using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Battle Set Up", menuName ="Set Up")]
public class BattleSetUp : ScriptableObject
{
    public string bullyBattle;

    public GameObject SwingBattle;

    // Start is called before the first frame update
    void Start()
    {
        if (bullyBattle.Contains("Swing")) {
            SwingBattle.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDialogueTree() {

    }
}
