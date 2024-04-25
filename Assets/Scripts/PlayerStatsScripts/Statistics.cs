using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Statistics", menuName ="Statistics")]
public class Statistics : ScriptableObject
{
    public int athletics, reputation, language, creativity, math, actions;

    public void UpdateStat(string stat, int add) {
        if (stat == "athletics") {
            athletics += add;
        }
        else if (stat == "reputation") {
            reputation += add;
        }
        else if (stat ==  "language") {
            language += add;
        }
        else if (stat == "creativity") {
            creativity += add;
        }
        else if (stat == "math") {
            math += add;
        }
        else if (stat == "actions") {
            actions += add;
        }
    }

    public void LeaveBattle() {
        if (reputation < 5) {
            reputation = 0;
        }
        else {
            reputation -= 5;
        }
    }
}

