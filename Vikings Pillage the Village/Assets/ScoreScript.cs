using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float score;
    public float highscore;
    public Text scoreText;
    public Text scoreOnDeathText;
    public Text Highscore;
    private GameObject scorePanel;

    private void Start()
    {
        score = 0;
        scorePanel = GameObject.Find("Score");
        highscore = PlayerPrefs.GetFloat("Highscore");
    }


    public void addScore()
    {
        score += 10;
        scoreText.text = "Score: " + score.ToString();
        if (highscore < score)
        {
            highscore = score;
            PlayerPrefs.SetFloat("Highscore", highscore);
        }
    }

    public float getScore()
    {
        return score;
    }

    public void setHighscore(float Hs)
    {
        highscore = Hs;
    }

    public float getHighScore()
    {
        return highscore;
    }

    public void addScoreOnDeath()
    {
        scoreOnDeathText.text = "Your Score: " + score.ToString();
        Highscore.text = "HighScore: " + highscore.ToString();
        scorePanel.SetActive(false);
    }


}
