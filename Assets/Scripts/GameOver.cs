using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject backgroundMusic;
    public GameObject score;
    public GameObject highScore;

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
            gameOverPanel.SetActive(true);
            score.SetActive(false);
            highScore.SetActive(false);
            
            Destroy(backgroundMusic);
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
