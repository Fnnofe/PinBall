using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    AudioSource YaySound;

    public int iLevelToLoad;
    public string sLevelToLoad;

   public static ScoreManager instance;

    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    public bool useIntegerToLoadLevel = false;

   public int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        YaySound = GetComponent<AudioSource>();
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " Balls Scored" ;
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text= score.ToString() + " Balls Scored";
        if (highscore < score)
        PlayerPrefs.SetInt("highscore", score);
    }
    void Update()
    {
        if (score == 3)
        {
            YaySound.Play();
            Invoke("LoadScene", 1f);
            //YaySound.Play();
        }
    }

    void LoadScene()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }

        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}
