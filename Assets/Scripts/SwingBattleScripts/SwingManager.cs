using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwingManager : MonoBehaviour
{
    public SwingController bullySwing;
    public SwingController playerSwing; 
    public ProgressBarManager progressBar;
    public GameObject progressBarObject;

    private bool finished = false;

    public void Update() {
        if (!finished) {
            UpdateProgressBar();
        }
    }

    public void UpdateProgressBar() {
        if (bullySwing.tiltAngle > 0) {
            progressBar.SetBullyProgress(bullySwing.tiltAngle/160.0f);
        }

        if (playerSwing.tiltAngle > 0) {
            progressBar.SetPlayerProgress(playerSwing.tiltAngle/160.0f);
        }
    }

    public void TurnOffProgressUpdates() {
        finished = true;
    }

}
