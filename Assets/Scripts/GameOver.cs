using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject backgroundMusic;
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
            //backgroundMusic.GetComponent<AudioSource>().Stop();
            Destroy(backgroundMusic);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //backgroundMusic.GetComponent<AudioSource>().Play();
        ScoreManager.score = 0;
        m.Awake();
    }
}
