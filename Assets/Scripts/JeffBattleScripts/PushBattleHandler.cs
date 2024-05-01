using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBattleHandler : MonoBehaviour
{
    public ProgressBarManager progressBar;

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

    public void Update() {
        // if (battleStarted) {
        //     UpdateProgressBar();
        // }

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

        yield return new WaitForSeconds(1f);


    }
}
