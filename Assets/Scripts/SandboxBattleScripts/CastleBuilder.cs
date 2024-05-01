using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CastleBuilder : MonoBehaviour
{
    public List<Sprite> castleLevels;
    public SpriteRenderer playerCastle, bullyCastle;
    public ProgressBarManager progressBar;
    public UnityEvent winDialogueStart;
    public UnityEvent loseDialogueStart;

    public Statistics playerStat;
    public Statistics bullyStat;

    private int playerBuildIndex, bullyBuildIndex;

    // Start is called before the first frame update
    void Start()
    {
        playerBuildIndex = 0;
        bullyBuildIndex = 0;

        playerCastle.sprite = castleLevels[playerBuildIndex];
        bullyCastle.sprite = castleLevels[bullyBuildIndex];

        StartCoroutine(AnimateCastles());
    }

    
    // Update is called once per frame
    void Update()
    {
        // make this a 12 second animation 
        // roughly 1.5 seconds per sprite
        // only change sprite if you reach a threshold
    }

    public IEnumerator AnimateCastles() {
        int seconds = 0; // 12 second animation

        float playerCount = 0;
        int playerThreshold = 4;

        float bullyCount = 0;
        int bullyThreshold = 4;


        while (playerBuildIndex <= 6 && bullyBuildIndex <= 6) {
            Debug.Log("PlayerBuildIndex = " + playerBuildIndex + " bullybuildindex = " + bullyBuildIndex);
            playerCount += (playerStat.creativity / 12.0f);
            

            bullyCount += (bullyStat.creativity / 12.0f);

            playerThreshold = AnimatePlayerCastleBasedOnThreshold(playerThreshold, playerCount);
            bullyThreshold = AnimateBullyCastleBasedOnThreshold(bullyThreshold, bullyCount);
            
            yield return new WaitForSeconds(0.5f);
            seconds += 1;
        }

        Debug.Log("DONE!");
        yield return new WaitForSeconds(1f);

        if (playerBuildIndex > bullyBuildIndex) { // player wins!
            winDialogueStart.Invoke();
        }
        else {
            loseDialogueStart.Invoke();
        }
    }

    private int AnimateBullyCastleBasedOnThreshold(int threshold, float count) {
        if (count >= threshold) {
            bullyBuildIndex += 1;

            bullyCastle.sprite = castleLevels[bullyBuildIndex];
            progressBar.SetBullyProgress((bullyBuildIndex/14.0f));
            return threshold + 4;
        }
        return threshold;

    }

    private int AnimatePlayerCastleBasedOnThreshold(int threshold, float count) {
            if (count >= threshold) { 
                if (playerBuildIndex != 6) {
                    playerBuildIndex += 1;
                }
                else {  
                    playerBuildIndex = 8;
                }
                
                playerCastle.sprite = castleLevels[playerBuildIndex];
                progressBar.SetPlayerProgress(playerBuildIndex/14.0f);
                return threshold + 4;
            }
            return threshold;

    }


}
