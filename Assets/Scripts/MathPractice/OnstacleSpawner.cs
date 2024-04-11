using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnstacleSpawner : MonoBehaviour
{
    public static float columnSpeed;
    public float maxTime = 5;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        columnSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 20);
            timer = 0;
            count ++;
        }

        timer += Time.deltaTime;
        
        if(count >= 5){
            columnSpeed += 0.4f;
            maxTime -= 0.7f;
            count = 0;
        }
    }
}
