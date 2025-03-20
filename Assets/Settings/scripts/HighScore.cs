using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScore : MonoBehaviour
{

    private int highscore;
    private Player_Controller playerController;
    private int tempScore;

    private TextMeshProUGUI HighScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tempScore = 0;
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        HighScoreText = GetComponentInChildren<TextMeshProUGUI>();
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerController = player.GetComponent<Player_Controller>();
        }

        UpdateHighScore(highscore);
    }

    // Update is called once per frame
    void Update()
    {
        tempScore = playerController.GetScore();

       if(tempScore > highscore)
        {
            UpdateHighScore(tempScore);
        }

       highscore = playerController.GetScore();

    }

    void UpdateHighScore(int newScore)
    {
        highscore = newScore;
        PlayerPrefs.SetInt( "highScore", highscore);
        PlayerPrefs.Save();
        string message = string.Format("HIGH SCORE: {0:D7}", highscore);
        HighScoreText.SetText(message);
    }
}
