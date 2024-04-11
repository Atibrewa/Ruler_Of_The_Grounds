using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CompareDrawings : MonoBehaviour
{

    public ReferenceSpriteController refEars, refHead, refArms, refEyes, refMouth, refMisc;
    public DrawingSpriteController paintEars, paintHead, paintArms, paintEyes, paintMouth, paintMisc;
    public TextMeshProUGUI scoreLabel;

    public Statistics userStat;


    public void Compare() {
        // get reference combination 
        bool match = false;
        int score = 0;

        // match = (headRef.randomSpriteIndex == headDraw.index) &
        //         (earRef.randomSpriteIndex == earsDraw.index) &
        //         (mouthRef.randomSpriteIndex == mouthDraw.index);

    

        if (refEars.randomSpriteIndex == paintEars.index) {
            score += 1;
        }

        if (refHead.randomSpriteIndex == paintHead.index) {
            score += 1;
        }

        if (refArms.randomSpriteIndex == paintArms.index) {
            score += 1;
        }

        if (refEyes.randomSpriteIndex == paintEyes.index) {
            score += 1;
        }

        if (refMouth.randomSpriteIndex == paintMouth.index) {
            score += 1;
        }

        if (refMisc.randomSpriteIndex == paintMisc.index) {
            score += 1;
        }

        userStat.UpdateStat("creativity", score);
        scoreLabel.text = "Creativity: +" + score;
    
    }
}
