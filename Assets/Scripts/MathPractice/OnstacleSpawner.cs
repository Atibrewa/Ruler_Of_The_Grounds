using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnstacleSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject newpipe = Instantiate(pipe);
        timer = 0;
        
    }
}
