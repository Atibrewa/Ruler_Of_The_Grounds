using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;

public class TeacherScript : MonoBehaviour {

    public float min_seconds;
    public float max_seconds;

    public GameObject thought_bubble;

    // Start is called before the first frame update
    void Start() {
        thought_bubble.SetActive(false);
        TeachCycle();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void TeachCycle() {
        float secs = Random.Range(min_seconds, max_seconds);
        Debug.Log(secs);
        StartCoroutine(Look(secs));
    }

    IEnumerator Look(float secs) {
        yield return new WaitForSeconds(secs);
        thought_bubble.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Look_Animate();
        thought_bubble.SetActive(false);
        yield return new WaitForSeconds(1f);
        Look_Animate();
        TeachCycle();
    }

    void Look_Animate() {
        Debug.Log("in Look_Animate");
        Vector3 scale = transform.localScale;
        float scaleX = scale.x;
        scale.x = -scaleX;
        transform.localScale = scale;
    }
}
