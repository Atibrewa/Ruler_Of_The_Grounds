using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceSpriteController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public CreativitySprites sprites;
    public int randomSpriteIndex = -1;
    // Start is called before the first frame update

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        GenerateImage();
    }

    /**
    * The GenerateImage() method is solely for sprites that belong to ReferenceObjects. 
    * It randomly generates a new sprite. 
    */
    void GenerateImage() {
        // randomSpriteIndex = Random.Range(0, 3);
        // ChangeSprite(sprites[randomSpriteIndex]);

        // randomSpriteIndex = Random.Range(0, 3);
        if (gameObject.name.Contains("Ears")) {
            randomSpriteIndex = Random.Range(0, sprites.earSprites.Count);
            ChangeSprite(sprites.earSprites[randomSpriteIndex]);
        }
        else if (gameObject.name.Contains("Head")) {
            randomSpriteIndex = Random.Range(0, sprites.headSprites.Count);
            ChangeSprite(sprites.headSprites[randomSpriteIndex]);   
        }
        else if (gameObject.name.Contains("Arms")) {
            randomSpriteIndex = Random.Range(0, sprites.armsSprites.Count);
            ChangeSprite(sprites.armsSprites[randomSpriteIndex]);
        }
        else if (gameObject.name.Contains("Eye")) {
            randomSpriteIndex = Random.Range(0, sprites.eyeSprites.Count);
            ChangeSprite(sprites.eyeSprites[randomSpriteIndex]);   
        }
        else if (gameObject.name.Contains("Mouth")) {
            randomSpriteIndex = Random.Range(0, sprites.mouthSprites.Count);
            ChangeSprite(sprites.mouthSprites[randomSpriteIndex]);
        }
        else if (gameObject.name.Contains("Misc")) {
            randomSpriteIndex = Random.Range(0, sprites.miscSprites.Count);
            ChangeSprite(sprites.miscSprites[randomSpriteIndex]);   
        }
    //    Debug.Log("The index of " + gameObject.name + " is " + randomSpriteIndex);
    }

    void ChangeSprite(Sprite sprite) {
        spriteRenderer.sprite = sprite;
    }
}
