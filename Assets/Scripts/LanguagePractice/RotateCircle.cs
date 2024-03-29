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
        // Quaternion target = Quaternion.Euler(0, 0, rotation);
        // body.transform.rotation = Quaternion.Slerp(body.transform.rotation, target,  Time.deltaTime);
        // rotation += 10;
        // transform.Rotate(0, 0, 40 * Time.deltaTime);

 
        //  alpha += Time.deltaTime;
        // var x = Mathf.Cos(alpha);
        // var z = Mathf.Sin(alpha);
        // rotation.x = x;
        // rotation.z = z;
        // transform.rotation = Quaternion.Euler(rotation* Time.deltaTime);

        transform.Rotate(0, 0, 40 * Time.deltaTime);


    }
}
