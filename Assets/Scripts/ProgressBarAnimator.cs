using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarAnimator : MonoBehaviour
{
    public Image playerProgress;
    public Image bullyProgress;
    private float xScale = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerProgress.GetComponent<Transform>().localScale = new Vector3(0, 1, 1);
        bullyProgress.GetComponent<Transform>().localScale = new Vector3(0, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (xScale < 1) {
            if (Input.GetAxis("Horizontal") > 0 ) {
                xScale += 0.001f;
                playerProgress.GetComponent<Transform>().localScale = new Vector3(xScale, 1,1);
            }
            if (Input.GetAxis("Horizontal") < 0 ) {
                xScale -= 0.001f;
                playerProgress.GetComponent<Transform>().localScale = new Vector3(xScale, 1,1);
            }
        }
        
        // xScale += 0.01f;
        // playerProgress.GetComponent<Transform>().localScale = new Vector3(xScale, 1,1);
        // bullyProgress.GetComponent<Transform>().localScale = new Vector3(0, 1, 1);
    }
}
