using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnSeesaw : MonoBehaviour
{
    public List<Sprite> jumpSprites;
    public int midAirIndex = 4;
    public Statistics stats;
    public Statistics opponentStats;

    public SpriteRenderer gameSprite;
    private int index = 0;
    private Rigidbody2D body;
    private float pushWeight;
    private float weight;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        pushWeight = 0;
        DetermineWeight();
        // StartCoroutine(JumpAFewTimes());
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 10) {
            ManageWeightPerJump();
        }
        else {
            Debug.Log(gameObject.name + " lost!");
        }
        

    }

    private void ManageWeightPerJump() {
        if (body.velocity.y > 2) {
            body.mass = 5;
        }
        else if (body.velocity.y > -1 && body.velocity.y < 0) {
            pushWeight += weight;          
        }
        else {
            body.mass = (15 + pushWeight);
        }  
    }

    private void DetermineWeight() {
        if (stats.math > opponentStats.math) {
            weight = (15/200.0f);
        }
        else if (stats.math == opponentStats.math) {
            if (gameObject.name.Contains("Player")) {
                weight = (5/200.0f);
            }
            else {
                weight = (15/200.0f);
            }   
        }
        else {
            weight = (5/200.0f);
        }
        Debug.Log(gameObject.name + "'s push weight is: " + weight);

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
