using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpOnSeesaw : MonoBehaviour
{
    public Statistics stats;
    public ProgressBarManager progressBar;
    public UnityEvent winEvent; 
    public UnityEvent winDialogueStart;
    public UnityEvent loseDialogueStart;
    public AudioSource seesawSound;


    private float bounceCount;
    private Rigidbody2D body;
    private bool running;
    private bool isPlayer;
    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        bounceCount = 0f;
        running = true;

        isPlayer = gameObject.name.Contains("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (bounceCount > 4.0f) {
            running = false;
            winEvent.Invoke();
        }

        if (transform.position.x > 9.0f) {
            Debug.Log("bully wins");
            loseDialogueStart.Invoke();
        }

        if (transform.position.x < -9.0f) {
            Debug.Log("player wins");
            Debug.Log(gameObject.name + " called player wins");
            winDialogueStart.Invoke();
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (running) {
            seesawSound.Play();
            body.velocity = (transform.up * -15.0f);
            body.mass = 15;
            bounceCount += (stats.math/50.0f);
            Debug.Log(gameObject.name + "'s bounceCount: " + bounceCount);

            SetProgressBar(bounceCount/8.0f);
        }
    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        if (running) {
            body.velocity = (transform.up * 15.0f);
            body.mass = 1;
        }
        
    }

    private void SetProgressBar(float amount) {
        if (isPlayer) {
            progressBar.SetPlayerProgress(amount);
        }
        else {
            progressBar.SetBullyProgress(amount);
        }
    }

    public void GoFlyingOff() {
        running = false;

        body.constraints = RigidbodyConstraints2D.None;
        body.freezeRotation = false;
        transform.Rotate(0, 0, 1);
        
        if (isPlayer) {
         
            body.velocity = new Vector3(20, 15, 0);
            // StartCoroutine(WaitAFewSeconds(loseDialogueStart));
            // loseDialogueStart.Invoke();
            
        }
        else {
        
            body.velocity = new Vector3(-20, 15, 0);
            // StartCoroutine(WaitAFewSeconds(winDialogueStart));
            // winDialogueStart.Invoke();
            
        }

    }

    public IEnumerator WaitAFewSeconds(UnityEvent battleEvent) {
        int seconds = 2;
        while (seconds > 0) {
            yield return new WaitForSeconds(1f);
            seconds -= 1;
        }
        battleEvent.Invoke();
    }
}
