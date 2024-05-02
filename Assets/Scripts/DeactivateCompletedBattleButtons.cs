using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactivateCompletedBattleButtons : MonoBehaviour
{
    public Statistics stat;

    public Button swingButton, minnieButton, sandcastleButton, seesawButton, structureButton;
    private bool done;

    void Start() {
        swingButton.enabled = !stat.getStickerbyStructureName("swings");
        minnieButton.enabled = !stat.getStickerbyStructureName("minnie");
        sandcastleButton.enabled = !stat.getStickerbyStructureName("sandbox");
        seesawButton.enabled = !stat.getStickerbyStructureName("seesaw");
        structureButton.enabled = !stat.getStickerbyStructureName("playstructure");

    }

    void Update() {
        
    }

}
