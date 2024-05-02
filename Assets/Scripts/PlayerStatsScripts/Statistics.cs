using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Statistics", menuName ="Statistics")]
public class Statistics : ScriptableObject
{
    public int athletics, reputation, language, creativity, math, actions;
    private bool swings, seesaw, minnie, playstructure, sandbox = false;

    public void UpdateStat(string stat, int add) {
        if (stat == "athletics") {
            athletics += add;
            if (athletics > 50) {
                athletics = 50;
            }
            else if (athletics < 0) {
                athletics = 0;
            }
        }
        else if (stat == "reputation") {
            reputation += add;
            if (reputation > 50) {
                reputation = 50;
            }
            else if (reputation < 0) {
                reputation = 0;
            }
        }
        else if (stat ==  "language") {
            language += add;
            if (language > 50) {
                language = 50;
            }
            else if (language < 0) {
                language = 0;
            }
        }
        else if (stat == "creativity") {
            creativity += add;
            if (creativity > 50) {
                creativity = 50;
            }
            else if (creativity < 0) {
                creativity = 0;
            }
        }
        else if (stat == "math") {
            math += add;
            if (math > 50) {
                math = 50;
            }
            else if (math < 0) {
                math = 0;
            }
        }
        else if (stat == "actions") {
            actions += add;
            if (actions > 2) {
                actions = 2;
            }
            else if (actions < 0) {
                actions = 0;
            }
        }
    }

    public void Subtract5FromReputation() {
        Debug.Log("Subtracted 5 from rep");
        UpdateStat("reputation", -5);
    }

    public void Add5ToReputation() {
        Debug.Log("Added 5 from rep");
        UpdateStat("reputation", 5);
    }

    public void LeaveBattle() {
        // if (reputation < 1) {
        //     reputation = 0;
        // }
        // else {
        //     reputation -1;
        // }
    }

    public void setStickerbyStructureName(string structure) {
        if (structure == "swings") {
            swings = true;
        } else if (structure == "seesaw") {
            seesaw = true;
        } else if (structure == "minnie") {
            minnie = true;
        } else if (structure == "sandbox") {
            sandbox = true;
        } else if (structure == "playstructure") {
            playstructure = true;
        }
    }

    public bool getStickerbyStructureName(string structure) {
        if (structure == "swings") {
            return swings;
        } else if (structure == "seesaw") {
            return seesaw;
        } else if (structure == "minnie") {
            return minnie;
        } else if (structure == "sandbox") {
            return sandbox;
        } else if (structure == "playstructure") {
            return playstructure;
        } else {
            return false;
        }
    }
}

