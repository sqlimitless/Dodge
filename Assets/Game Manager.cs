using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // public GameObject gameObject;
    public Text score;
    public Text gameOver;
    public Text bestScore;
    private float time = 0;
    private Boolean isGameOver = false;
    private int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Time: 0";
        gameOver.gameObject.SetActive(false);
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver){
            gameOver.gameObject.SetActive(true);
        }else{
            time += Time.deltaTime;
            score.text = "Time: " + Mathf.FloorToInt(time).ToString();
        }
        
    }

    public void GameOver(){
        isGameOver = true;
        gameOver.gameObject.SetActive(true);
        int currentScore = Mathf.FloorToInt(time);
        if(currentScore > highScore){
            PlayerPrefs.SetInt("HighScore", currentScore);
        }
        bestScore.text =  Mathf.FloorToInt(time).ToString();
        bestScore.gameObject.SetActive(true);
    }
}
