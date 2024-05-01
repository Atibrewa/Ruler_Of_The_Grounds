using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsCanvasScript : MonoBehaviour {

    public TMP_Text athleticsText;
    public TMP_Text reputationText;
    public TMP_Text languageText;
    public TMP_Text creativityText;
    public TMP_Text mathematicsText;
    public Image reputationBar;
    public Image athleticsBar;
    public Image creativityBar;
    public Image languageBar;
    public Image mathBar;
    public Statistics stats;
    public GameObject swingsSticker, seesawSticker, minnieSticker, sandboxSticker, EmperorSticker;

    public void updateText() {
        athleticsText.SetText("Athletics: " + stats.athletics.ToString());
        athleticsBar.fillAmount = stats.athletics/50f;
        reputationText.SetText("Reputation: " + stats.reputation.ToString());
        reputationBar.fillAmount = stats.reputation/50f;
        languageText.SetText("Language: " + stats.language.ToString());
        languageBar.fillAmount = stats.language/50f;
        creativityText.SetText("Creativity: " + stats.creativity.ToString());
        creativityBar.fillAmount = stats.creativity/50f;
        mathematicsText.SetText("Math: " + stats.math.ToString());
        mathBar.fillAmount = stats.math/50f;
        UpdateStickers();
    }

    private void UpdateStickers() {
        swingsSticker.SetActive(stats.getStickerbyStructureName("swings"));
        seesawSticker.SetActive(stats.getStickerbyStructureName("seesaw"));
        minnieSticker.SetActive(stats.getStickerbyStructureName("minnie"));
        sandboxSticker.SetActive(stats.getStickerbyStructureName("sandbox"));
        EmperorSticker.SetActive(stats.getStickerbyStructureName("playstructure"));
    }
}
