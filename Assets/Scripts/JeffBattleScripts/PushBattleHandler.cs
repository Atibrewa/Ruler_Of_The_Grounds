using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PushBattleHandler : MonoBehaviour
{
    public ProgressBarManager progressBar;
    public UnityEvent winAnimation, loseAnimation;
    public UnityEvent winDialogueStart, loseDialogueStart;


    private int wins = 0;
    private bool battleStarted;
    private float playerPlusAmount, bullyPlusAmount;
    private float playerTotalProgress, bullyTotalProgress;
    

    // Start is called before the first frame update
    void Start()
    {
        battleStarted = false;

        playerTotalProgress = 0;
        bullyTotalProgress = 0;
    }

    private void UpdateProgressBar() {
        progressBar.SetPlayerProgress(playerTotalProgress);
        progressBar.SetBullyProgress(bullyTotalProgress);

        playerTotalProgress += playerPlusAmount;
        bullyTotalProgress += bullyPlusAmount;

    }

    public void InitiateBattle() {
        battleStarted = true;
        if (wins > 3) {
            playerPlusAmount = 0.05f;
            bullyPlusAmount = 0.01f;
        }
        else {
            playerPlusAmount = 0.01f;
            bullyPlusAmount = 0.05f;
        }

        StartCoroutine(AnimatePushProgress());
    }

    public void AddOneWin() {
        wins += 1;
        Debug.Log("Adding one win ");
    }

    public IEnumerator AnimatePushProgress() {
        int seconds = 0; // 12 second animation
        

        while (playerTotalProgress <= 0.55f && bullyTotalProgress <= 0.55f) {
            
            UpdateProgressBar();
            yield return new WaitForSeconds(0.5f);
            seconds += 1;
        }
        bool win = (playerTotalProgress > bullyTotalProgress);

        if (win) {
            winAnimation.Invoke();
            yield return new WaitForSeconds(2f);
            winDialogueStart.Invoke();
        }
        else {
            loseAnimation.Invoke();
            yield return new WaitForSeconds(2f);
            loseDialogueStart.Invoke();
        }


    }
}
