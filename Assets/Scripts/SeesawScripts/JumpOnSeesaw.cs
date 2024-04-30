using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnSeesaw : MonoBehaviour
{
    public Statistics stats;
    public Statistics opponentStats;

    public SpriteRenderer gameSprite;
    private float bounceCount;
    private Rigidbody2D body;
    public ProgressBarManager progressBar;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        bounceCount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (bounceCount > 8.0f) {
            Debug.Log(gameObject.name + " wins!");
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        body.velocity = (transform.up * -15.0f);
        body.mass = 15;
        bounceCount += (stats.math/50.0f);
        Debug.Log(gameObject.name + "'s bounceCount: " + bounceCount);

        SetProgressBar(bounceCount/16.0f);

    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        body.velocity = (transform.up * 15.0f);
        body.mass = 1;
    }

    private void SetProgressBar(float amount) {
        if (gameObject.name.Contains("Player")) {
            progressBar.SetPlayerProgress(amount);
        }
        else {
            progressBar.SetBullyProgress(amount);
        }
    }
}
