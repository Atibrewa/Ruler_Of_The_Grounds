using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarManager : MonoBehaviour
{
    public GameObject progressBar;
    public Image bullySprite;
    public List<Sprite> bullySprites;

    private Image bullyProgressBar, playerProgressBar;
    
    // Start is called before the first frame update
    void Start()
    {
        bullyProgressBar = progressBar.transform.GetChild(1).gameObject.GetComponent<Image>();
        bullyProgressBar.fillAmount = 0;
        playerProgressBar = progressBar.transform.GetChild(2).gameObject.GetComponent<Image>();
        playerProgressBar.fillAmount = 0;
    }

    public void SetBullySprite() {
        // TODO: SET BULLY SPRITE IMAGE!
        // bullySprite.sprite = bullySprites[index]
    }

    public void SetPlayerProgress(float amount) {
        playerProgressBar.fillAmount = amount;
    }

    public void SetBullyProgress(float amount) {
        bullyProgressBar.fillAmount = amount;
    }
}
