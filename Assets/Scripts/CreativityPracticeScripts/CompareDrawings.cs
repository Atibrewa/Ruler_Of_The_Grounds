using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CompareDrawings : MonoBehaviour
{

    public ReferenceSpriteController headRef, earRef, mouthRef;
    public DrawingSpriteController headDraw, earsDraw, mouthDraw;
    public TextMeshProUGUI scoreLabel;

    public Statistics userStat;


    public void Compare() {
        // get reference combination 
        bool match = false;
        int score = 0;

        match = (headRef.randomSpriteIndex == headDraw.index) &
                (earRef.randomSpriteIndex == earsDraw.index) &
                (mouthRef.randomSpriteIndex == mouthDraw.index);

        Debug.Log("The Match results are: " + match);

        if (headRef.randomSpriteIndex == headDraw.index) {
            score += 1;
        }

        if (earRef.randomSpriteIndex == earsDraw.index) {
            score += 1;
        }

        if (mouthRef.randomSpriteIndex == mouthDraw.index) {
            score += 1;
        }

        userStat.UpdateStat("creativity", score);
        scoreLabel.text = "Creativity: +" + score;
    
    }
}
