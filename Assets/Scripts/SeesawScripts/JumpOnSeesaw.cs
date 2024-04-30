using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnSeesaw : MonoBehaviour
{
    public List<Sprite> jumpSprites;
    public int midAirIndex = 4;
    public Statistics stats;
    public Statistics opponentStats;
    public BoxCollider2D triggerCollider;

    public SpriteRenderer gameSprite;
    private int index = 0;
    private Rigidbody2D body;
    private float pushWeight;
    private float weight;
    private bool jumped = false;
    private int count = 0;

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
            //ManageWeightPerJump();
        }
        else {
            Debug.Log(gameObject.name + " loses!");
        }

    }

    private void JumpAFewTimes() {
        if (body.velocity.y > 2) {
            body.mass = 5;
        }
        else {
            body.mass = (15 + pushWeight);
        }  
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gameObject.name +  " hit " + other.name);
        // body.mass = (15 + pushWeight);
        // body.velocity = (transform.up * 5.0f);
        // body.mass = 1;
        body.velocity = (transform.up * -20.0f);
        body.mass = (15 + pushWeight);

    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log(gameObject.name +  " exits " + other.name);
        body.velocity = (transform.up * 20.0f);
        body.mass = 1;
        // body.mass = (15 + pushWeight);
        pushWeight += weight;   
    }

   

    // private void ManageWeightPerJump() {
    //     if (body.velocity.y > 2) {
    //         body.mass = 5;
    //     }
    //     else if (body.velocity.y > -1 && body.velocity.y < 0) {
    //         pushWeight += weight;          
    //     }
    //     else {
    //         body.mass = (15 + pushWeight);
    //     }  
    // }

    private void DetermineWeight() {
        if (stats.math > opponentStats.math) {
            weight = (15/100.0f);
        }
        else if (stats.math == opponentStats.math) {
            if (gameObject.name.Contains("Player")) {
                weight = (5/100.0f);
            }
            else {
                weight = (15/100.0f);
            }   
        }
        else {
            weight = (5/100.0f);
        }
        Debug.Log(gameObject.name + "'s push weight is: " + weight);

    }
}
