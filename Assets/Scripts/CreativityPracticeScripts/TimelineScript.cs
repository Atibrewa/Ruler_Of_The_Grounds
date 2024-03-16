using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimelineScript : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        // {
        //     Debug.Log($"Animation over");
        // }
    }

    public void ShowUI() {
        canvas.enabled = true;
    }
}
