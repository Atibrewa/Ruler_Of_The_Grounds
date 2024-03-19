using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragController : MonoBehaviour
{

    public LineRenderer line;
    public Rigidbody2D rb;

    public float dragLimit = 3f;
    public float forceToAdd = 10f;

    private Camera cam;
    private bool isDragging;
    // Start is called before the first frame update

    Vector3 MousePosition {
        get {
            Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;
            return pos;
        }
    }

    void Start() {
        cam = Camera.main;
        line.positionCount = 2;
        line.SetPosition(0, Vector2.zero);
        line.SetPosition(1, Vector2.zero);
        line.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0) && !isDragging) {
            DragStart();
        }
        if(isDragging) {
            Drag();
        }
        if(Input.GetMouseButtonUp(0) && isDragging) {
            DragEnd();
        }
    }

    void DragStart() {
        line.enabled = true;
        isDragging = true;
        line.SetPosition(0, MousePosition);
    }

    void Drag() {
        Vector3 startPos = line.GetPosition(0);
        Vector3 currentPos = MousePosition;

        Vector3 distance = currentPos - startPos;

        if (distance.magnitude <= dragLimit) {
            line.SetPosition(1, currentPos);
        }
        else {
            Vector3 limitVector = startPos + (distance.normalized * dragLimit);
            line.SetPosition(1, limitVector);
        }
    }

    void DragEnd() {
        isDragging = false;
        line.enabled = false;

        Vector3 startPos = line.GetPosition(0);
        Vector3 currentPos = line.GetPosition(1);

        Vector3 distance = currentPos - startPos;
        Vector3 finalForce = distance * forceToAdd;

        rb.AddForce(-finalForce, ForceMode2D.Impulse);

    }
}
