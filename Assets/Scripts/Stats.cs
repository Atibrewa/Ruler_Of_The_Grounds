using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="CurrentStat", menuName="Stat/stat")]
public class Stats : ScriptableObject
{
    public int Athletics;
    public int Math;
    // Start is called before the first frame update
    void Start()
    {
        Athletics = 0;
        Math = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMath(int add)
    {
        Math += add;
    }
}
