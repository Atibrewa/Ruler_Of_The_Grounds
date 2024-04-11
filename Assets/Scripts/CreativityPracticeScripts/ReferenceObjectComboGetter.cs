using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceObjectComboGetter : MonoBehaviour
{
    public ReferenceSpriteController headController, earsController, mouthController;
    private bool firstCall = true;
    private List<int> combination = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void GetIndices() {
        Debug.Log("Head index is:" + headController.randomSpriteIndex);
        Debug.Log("Ears index is:" + earsController.randomSpriteIndex);
        Debug.Log("Mouth index is:" + mouthController.randomSpriteIndex);
        combination.Add(headController.randomSpriteIndex);
        combination.Add(earsController.randomSpriteIndex);
        combination.Add(mouthController.randomSpriteIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (firstCall) {
            GetIndices();
            firstCall = false;
        }
    }
}
