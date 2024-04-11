using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MathManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TMP_Text text;
    public Statistics player;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        // Stops time
        Time.timeScale = 0;

        // Changes stat in player object
        player.UpdateStat("math", Score.score);

        // edits and displays the end game prefab
        text.text = "Stat: +" + Score.score.ToString();
        gameOverCanvas.SetActive(true);
    }
}
