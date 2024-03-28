using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Statistics", menuName ="Statistics")]
public class Statistics : ScriptableObject
{
    public int athleticism, reputation, language, creativity, mathematics;

    public void UpdateStat(string stat, int add) {
        if (stat == "athleticism") {
            athleticism += add;
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
        else if (stat == "mathematics") {
            mathematics += add;
        }
    }
}
