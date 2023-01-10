using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highScoreText;

    public static int score = 0;
    int highScore = 0;
    
    public void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {   
        highScore = PlayerPrefs.GetInt("highscore",0);
        scoreText.text = "Score: " + score.ToString() + " Points";
        highScoreText.text = "Highest Score : " + highScore.ToString()+" Points";

    }

    public void AddPoint()
    {
        score +=1;
        scoreText.text = "Score: " + score.ToString() + " Points";
        if (highScore < score)
            {
                PlayerPrefs.SetInt("highscore",score);
                PlayerPrefs.Save();
            }
    }


}
