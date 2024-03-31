using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewChanceEvent", menuName ="ChanceEvents/EventCard")]
public class ChanceObject : ScriptableObject
{
    public string eventText;
    public int athletics;
    public int creativity;
    public int language;
    public int math;
    public int reputation;
 
}