using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText;
    public static int highScore;
   
    // Start is called before the first frame update
    void Start()
    {
        highScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = "High Score: " + highScore;
    }
}
