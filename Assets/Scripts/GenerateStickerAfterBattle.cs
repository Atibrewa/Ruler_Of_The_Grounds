using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateStickerAfterBattle : MonoBehaviour
{
    public Sprite seesawSticker, swingSticker, jeffSticker, minnieSticker, sandboxSticker;
    public Image stickerImage;
    public Statistics playerStat;
    public BattleSetUp setUp;

    public void GenerateSticker()
    {
        if (playerStat.getStickerbyStructureName("swings") && setUp.bullyBattle.Contains("Swing")) {
            Debug.Log("swing win");
            stickerImage.sprite = swingSticker;
        }
        else if (playerStat.getStickerbyStructureName("minnie") && setUp.bullyBattle.Contains("Minnie")) {
            stickerImage.sprite = minnieSticker;
        }
        else if (playerStat.getStickerbyStructureName("sandbox") && setUp.bullyBattle.Contains("Sandcastle")) {
            stickerImage.sprite = sandboxSticker;
        }
        else if (playerStat.getStickerbyStructureName("seesaw") && setUp.bullyBattle.Contains("SeeSaw")) {
            stickerImage.sprite = seesawSticker;
        }
        else if (playerStat.getStickerbyStructureName("playstructure") && setUp.bullyBattle.Contains("Structure")) {
            stickerImage.sprite = jeffSticker;
        }
    }


}
