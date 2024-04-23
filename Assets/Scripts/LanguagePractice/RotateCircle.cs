using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    private Rigidbody2D body;
    public float alpha;

    public Vector3 rotation;
    // private int rotation = 10;
    // Start is called before the first frame update
    void Start()
    {
        // body = GetComponent<Rigidbody2D>();
        rotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 40 * Time.deltaTime);
    }
}
