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
    private float playerTargetAmount, bullyTargetAmount;
    private float smooth = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        bullyProgressBar = progressBar.transform.GetChild(1).gameObject.GetComponent<Image>();
        bullyProgressBar.fillAmount = 0;
        playerProgressBar = progressBar.transform.GetChild(2).gameObject.GetComponent<Image>();
        playerProgressBar.fillAmount = 0;

        playerTargetAmount = 0f;
        bullyTargetAmount = 0f;
    }

    public void SetBullySprite() {
        // TODO: SET BULLY SPRITE IMAGE!
        // bullySprite.sprite = bullySprites[index]
    }

    public void Update() {
        if (bullyProgressBar.fillAmount < bullyTargetAmount) {
            bullyProgressBar.fillAmount += (smooth * Time.deltaTime);
        }

        if (playerProgressBar.fillAmount < playerTargetAmount) {
            playerProgressBar.fillAmount += (smooth * Time.deltaTime);
        }
    }

    public void SetPlayerProgress(float amount) {
        // playerProgressBar.fillAmount = amount;
        playerTargetAmount = amount;
    }

    public void SetBullyProgress(float amount) {
        // bullyProgressBar.fillAmount = amount;
        bullyTargetAmount = amount;
    }
}
