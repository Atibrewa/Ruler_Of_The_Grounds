using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonScript : MonoBehaviour
{

    public Statistics stats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setUpStats() {
        stats.athletics = 5;
        stats.reputation = 5;
        stats.language = 5;
        stats.creativity = 5;
        stats.math = 5;
        stats.actions = 0;
    }
}
