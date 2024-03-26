using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareDrawings : MonoBehaviour
{

    public ReferenceSpriteController headRef, earRef, mouthRef;
    public DrawingSpriteController headDraw, earsDraw, mouthDraw;


    public void Compare() {
        // get reference combination 
        bool match = false;
        // match = (headRef.randomSpriteIndex == headDraw.index);
        // match = (earRef.randomSpriteIndex == earsDraw.index);
        // match = (mouthRef.randomSpriteIndex == mouthDraw.index);

        match = (headRef.randomSpriteIndex == headDraw.index) &
                (earRef.randomSpriteIndex == earsDraw.index) &
                (mouthRef.randomSpriteIndex == mouthDraw.index);

        Debug.Log("The Match results are: " + match);
        // TODO: based on match value trigger an event/animation that will inform user whether or not they got the match. 
        // Get Animation Object and play it (might be related to PlayableDirector)
    }
}
