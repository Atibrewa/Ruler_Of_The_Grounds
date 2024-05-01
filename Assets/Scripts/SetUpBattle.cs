using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUpBattle : MonoBehaviour
{
    public BattleSetUp setUp;

    public GameObject SwingBattle;
    public GameObject MinnieBattle;
    public GameObject SandcastleBattle;
    public GameObject SeesawBattle;
    public GameObject JeffBattle;


    public GameObject SwingSprite;
    public GameObject MinnieSprite;
    public GameObject RileySprite;
    public GameObject CecilSprite;
    public GameObject JeffSprite;
    // Start is called before the first frame update
    void Start()
    {
        if (setUp.bullyBattle.Contains("Swing")) {
            SwingBattle.SetActive(true);
            SwingSprite.SetActive(true);

        }
        else if (setUp.bullyBattle.Contains("Minnie")) {
            MinnieBattle.SetActive(true);
            MinnieSprite.SetActive(true);
        }
        else if (setUp.bullyBattle.Contains("Sandcastle")) {
            SandcastleBattle.SetActive(true);
            RileySprite.SetActive(true);
        }
        else if (setUp.bullyBattle.Contains("SeeSaw")) {
            SeesawBattle.SetActive(true);
            CecilSprite.SetActive(true);
        }
        else if (setUp.bullyBattle.Contains("Structure")) {
            JeffBattle.SetActive(true);
            JeffSprite.SetActive(true);
        }   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
