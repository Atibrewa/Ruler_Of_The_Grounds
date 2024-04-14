using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsMovement : MonoBehaviour
{
    public GameObject drawing;
    public float speed = 1f;
    public float maxTime = 5f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (timer > maxTime)
        {
            Destroy(drawing, 20);
        }

        timer += Time.deltaTime;
    }
}
