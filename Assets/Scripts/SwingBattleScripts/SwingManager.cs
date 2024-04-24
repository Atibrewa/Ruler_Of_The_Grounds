using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwingManager : MonoBehaviour
{
    public SwingController bullySwing;
    public SwingController playerSwing; 

    public GameObject progressBar;
    // private Transform bullyProgressBar, playerProgressBar;
    private Image bullyProgressBar, playerProgressBar;


    private bool finished = false;


    public void Start() {
        // bullyProgressBar = progressBar.transform.GetChild(1).gameObject.GetComponent<Transform>();
        // playerProgressBar = progressBar.transform.GetChild(2).gameObject.GetComponent<Transform>();

        bullyProgressBar = progressBar.transform.GetChild(1).gameObject.GetComponent<Image>();
        playerProgressBar = progressBar.transform.GetChild(2).gameObject.GetComponent<Image>();
    }

    public void Update() {
        if (!finished) {
            UpdateProgressBar();
        }
        
    }

    public void UpdateProgressBar() {
        // convert tiltAngle to be on the scale of 1.0f
        // now update the bullyProgressBar scale 
        if (bullySwing.tiltAngle > 0) {
            // bullyProgressBar.localScale = new Vector3(bullySwing.tiltAngle/160.0f, 1,1);
            bullyProgressBar.fillAmount +=  (bullySwing.tiltAngle/160.0f);
        }

        if (playerSwing.tiltAngle > 0) {
            //  playerProgressBar.localScale = new Vector3(playerSwing.tiltAngle/160.0f, 1,1);
            playerProgressBar.fillAmount +=  (playerSwing.tiltAngle/160.0f);
        }
       
        //Debug.Log("player progress bar is going: " + playerSwing.tiltAngle/80.0f);
    }

    public void TurnOffProgressUpdates() {
        finished = true;
    }


}
