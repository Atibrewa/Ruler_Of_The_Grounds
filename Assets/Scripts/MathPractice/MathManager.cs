using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MathManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TMP_Text text;
    public Statistics player;
    public AudioSource audioplayer;
    public AudioClip crashSound;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        // Plays crash sound
        audioplayer.PlayOneShot(crashSound);

        // Stops time
        Time.timeScale = 0;

        // Changes stat in player object
        player.UpdateStat("math", Score.score/2);

        // edits and displays the end game prefab
        text.text = "Stat: +" + (Score.score/2).ToString();
        gameOverCanvas.SetActive(true);
    }

    public void startTime()
    {
        Time.timeScale = 1;
    }
}
