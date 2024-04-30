using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnSeesaw : MonoBehaviour
{
    public Statistics stats;
    public Statistics opponentStats;

    public SpriteRenderer gameSprite;
    private int index = 0;
    private Rigidbody2D body;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        body.velocity = (transform.up * -15.0f);
        body.mass = 15;
    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        body.velocity = (transform.up * 15.0f);
        body.mass = 1;
    }
}
