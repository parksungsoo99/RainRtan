using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public GameObject Panel;
    public static GameManager I;
    int totalScore;
    public Text scoreText;
    public Text timeText;
    float limit = 60f;
    void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);
        initGame();
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        totalScore = 0;
        limit = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        limit -= Time.deltaTime;
        if (limit < 0)
        {
            Time.timeScale = 0.0f;
            Panel.SetActive(true);
            limit = 0.0f;
        }
        timeText.text = limit.ToString("N2"); // N2: 소수점 2자리까지만 출력하라
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    public void addScore(int score)
    { 
            totalScore += score;
        scoreText.text = totalScore.ToString();
    }
    
    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
