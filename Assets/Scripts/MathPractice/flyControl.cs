using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyControl : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rigidBody.velocity = Vector2.up * velocity;
        }
    }
}
