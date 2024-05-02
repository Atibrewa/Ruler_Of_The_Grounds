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
        Debug.Log("CALLED SET STICKER");
        if (structure == "swings") {
            Debug.Log("Swings has been to true");
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

