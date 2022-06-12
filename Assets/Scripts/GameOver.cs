using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject backgroundMusic;
    public GameObject gamePanelScore;
    public GameObject gamePanelHighScore;
    public Text gameOverScore;
    public Text gameOverHighScore;

    public BackgroundMusic m;

    private void Start()
    {
        backgroundMusic = GameObject.FindGameObjectWithTag("Music");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            Destroy(backgroundMusic);
            gameOverPanel.SetActive(true);
            gamePanelScore.SetActive(false);
            gamePanelHighScore.SetActive(false);
            gameOverScore.text = "SCORE: " + ScoreManager.score;
            gameOverHighScore.text = "HIGH SCORE: " + HighScoreManager.highScore;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (ScoreManager.score > HighScoreManager.highScore)
        {
            HighScoreManager.highScore = ScoreManager.score;
        }
        ScoreManager.score = 0;
        m.Awake();
    }
}
