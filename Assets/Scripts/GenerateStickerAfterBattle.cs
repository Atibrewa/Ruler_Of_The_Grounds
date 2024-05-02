using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateStickerAfterBattle : MonoBehaviour
{
    public Sprite seesawSticker, swingSticker, jeffSticker, minnieSticker, sandboxSticker;
    public Image stickerImage;
    public BattleSetUp setUp;
    // Start is called before the first frame update
    void Start()
    {
        if (setUp.bullyBattle.Contains("Swing")) {
            stickerImage.sprite = swingSticker;
        }
        else if (setUp.bullyBattle.Contains("Minnie")) {
            stickerImage.sprite = minnieSticker;
        }
        else if (setUp.bullyBattle.Contains("Sandcastle")) {
            stickerImage.sprite = sandboxSticker;
        }
        else if (setUp.bullyBattle.Contains("SeeSaw")) {
            stickerImage.sprite = seesawSticker;
        }
        else if (setUp.bullyBattle.Contains("Structure")) {
            stickerImage.sprite = jeffSticker;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
