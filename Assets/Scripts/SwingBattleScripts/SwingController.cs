using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwingController : MonoBehaviour
{
    private Rigidbody2D body;
    public Statistics charStatistics;

    float smooth = 5.0f;
    float tiltAngle = 5.0f;
    int direction = 1;
    public UnityEvent hitAngle;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ =  tiltAngle * direction; 
        

            Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
            if (Quaternion.Angle(body.transform.rotation, target) < 2) {
                direction = direction * -1;
                tiltAngle += 1.0f + charStatistics.athleticism;
            }

            if (tiltAngle < 100.0f) {
                body.transform.rotation = Quaternion.Slerp(body.transform.rotation, target,  Time.deltaTime * smooth);
            }
            else {
                hitAngle.Invoke();
                StopSwinging();
            }

    }

    public void StopSwinging() {
        direction = 0;

    }
}
