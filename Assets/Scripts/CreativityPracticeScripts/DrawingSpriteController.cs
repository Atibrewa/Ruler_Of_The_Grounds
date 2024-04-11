using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingSpriteController : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public CreativitySprites sprites;
    private List<Sprite> spriteList;
    public int index = 0;

    // Start is called before the first frame update
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        GetList();
        spriteRenderer.sprite = spriteList[0];
    }

    void GetList() {
        if (gameObject.name.Contains("Ear")) {
            spriteList = sprites.earSprites;
        }
        else if (gameObject.name.Contains("Head")) {
            spriteList = sprites.headSprites;
        }
        else if (gameObject.name.Contains("Arm")) {
            spriteList = sprites.armsSprites;
        }
        else if (gameObject.name.Contains("Eyes")) {
            spriteList = sprites.eyeSprites;
        }
        else if (gameObject.name.Contains("Mouth")) {
            spriteList = sprites.mouthSprites;
        }
        else if (gameObject.name.Contains("Misc")) {
            spriteList = sprites.miscSprites;
        }
    }

    public void UpdateSprite() {
        index = (index + 1) % spriteList.Count;
        Debug.Log("The index for the drawing object: " + gameObject.name + " is " + index);
        spriteRenderer.sprite = spriteList[index];
    }
}
