using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Statistics stats;

    public void PlayNewScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    public void PlayIfActions(string newScene) {
        if (stats.actions < 2) {
            stats.UpdateStat("actions", 1);
            PlayNewScene(newScene);
        }
    }

    public void GoBackActions(string newScene) {
        stats.UpdateStat("actions", -1);
        PlayNewScene(newScene);
    }

}
