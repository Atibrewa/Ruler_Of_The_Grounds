using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpBattle : MonoBehaviour
{
    public BattleSetUp setUp;
    

    public GameObject SwingBattle;
    public GameObject MinnieBattle;
    // Start is called before the first frame update
    void Start()
    {
        if (setUp.bullyBattle.Contains("Swing")) {
            SwingBattle.SetActive(true);
        }
        if (setUp.bullyBattle.Contains("Minnie")) {
            MinnieBattle.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}