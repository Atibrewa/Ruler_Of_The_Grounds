using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class SwingController : MonoBehaviour
{
    private Rigidbody2D body;
    private bool hit = false;
    public TextMeshProUGUI winLabel;
    public Statistics charStatistics;
    public BattleSetUp battle;

    float smooth = 5.0f;
    public float tiltAngle = 5.0f;
    int direction = 1;
    public UnityEvent winDialogueStart;
    public UnityEvent loseDialogueStart;

    private Quaternion target;

    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ =  tiltAngle * direction; 
            target = Quaternion.Euler(0, 0, tiltAroundZ);
            if (Quaternion.Angle(body.transform.rotation, target) < 2) {
                direction = direction * -1;
                tiltAngle += 1.0f + charStatistics.athletics;
            }

            if (tiltAngle < 80.0f) {
                body.transform.rotation = Quaternion.Slerp(body.transform.rotation, target,  Time.deltaTime * smooth);
            }
            else {
                if (!hit) {
                    hit = true;
                    if (gameObject.name.Contains("Billy")){
                        loseDialogueStart.Invoke();
                        
                    }
                    else {
                        winDialogueStart.Invoke();
                        
                    }
                    // Debug.Log(gameObject.name +  " HIT ANGLE EVOKED");
                    // hitAngle.Invoke();
                }
                
            }

    }

    private void UpdateLabel() {
        // if (gameObject.name == "Billy") {
        //     winLabel.text = gameObject.name + " wins!"; 
        //     results.win = false;
            
        // }
        // else {
        //     winLabel.text = gameObject.name + " win!"; 
        //     results.win = true;
        // }


    }

    public void StopSwinging() {
        hit = true;
        direction = 0;
        UpdateLabel();
    }
}
