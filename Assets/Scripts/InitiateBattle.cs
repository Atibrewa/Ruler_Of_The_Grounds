using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateBattle : MonoBehaviour
{
    public GameObject battle; 

    public void StartBattle() {
        battle.SetActive(true);
    }
}
