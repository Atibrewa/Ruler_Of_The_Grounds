using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SingleStat", menuName ="PlayerStat")]
public class SingleStat : ScriptableObject
{
    public string statName;
    public int statValue;
}
