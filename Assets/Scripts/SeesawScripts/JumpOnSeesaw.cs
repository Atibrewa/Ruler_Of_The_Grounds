using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnSeesaw : MonoBehaviour
{
    public List<Sprite> jumpSprites;
    public int midAirIndex = 4;

    public SpriteRenderer gameSprite;
    private int index = 0;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        // StartCoroutine(JumpAFewTimes());
    }

    // Update is called once per frame
    void Update()
    {
        // if (index + 1 >= jumpSprites.Count) {
        //     index = 0;
        // }
        // gameSprite.sprite = jumpSprites[index];
        // index += 1;
        // if (body.velocity )
        Debug.Log("body velocity" + body.velocity );
        if (body.velocity.y > 2) {
            Debug.Log("GOING UP!!");
            // body.AddForce(new Vector2(0, -1.0f));
            

        }
        else if (body.velocity.y > -1 && body.velocity.y < 0) {
            // body.AddForce(new Vector2(0, -1.0f));
            Debug.Log("***ADDING FORCE ON WAY DOWN ****");
            body.mass = 15;
        }
        else {
            Debug.Log("BACK TO NORMAL ==========");
            // body.AddForce(new Vector2(0, -1.0f));
            body.AddForce(new Vector2(0, 1.0f));
            body.mass = 1;
        }
          

    }

    public IEnumerator JumpAFewTimes() {
        int times = 0;
        while (times < 3) {
            Debug.Log("changing sprite");
            if (index + 1 >= jumpSprites.Count) {
                index = 0;
                times += 1;
            }
            gameSprite.sprite = jumpSprites[index];
            // transform.position += Vector3.down * 0.05f;
            index += 1;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(1f);
        // count.text = "";

        // timerDone.Invoke();
    }
}
