using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyOnePrefab;
    public GameObject cloudPrefab;
    public GameObject coinPrefab;

    //public PlayerController playerController;

    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;

    public float horizontalScreenSize;
    public float verticalScreenSize;
    public int score;
    public int coins;

    // Start is called before the first frame update
    void Start()
    {
        horizontalScreenSize = 8.5f;
        verticalScreenSize = 6.5f;
        score = 0;
        coins = 0;
        Instantiate(playerPrefab, transform.position, Quaternion.identity);

        CreateSky();
        InvokeRepeating("CreateEnemy", 1, 3);
        InvokeRepeating("CreateCoin", 1, 3);
        //playerController = GameObject.Find("PlayerController").GetComponent<PlayerController>();
        //livestext.text = "Lives" + playerController.lives;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //for coins
    public void AddCoins(int value)
    {
        coins += value;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + coins;
        }
    }


    public void AddScore(int earnedScore)
    {
        score = score + earnedScore;
    }

    public void ChangeLivesText(int currentLives)
    {
        livesText.text = "Lives: " + currentLives;
    }

    void CreateCoin()
    {
        Instantiate(coinPrefab, new Vector3(Random.Range(-horizontalScreenSize, horizontalScreenSize) * 0.3f, Random.Range(-verticalScreenSize, verticalScreenSize), 0), Quaternion.identity);
    }

    void CreateEnemy()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-horizontalScreenSize, horizontalScreenSize) * 0.9f, verticalScreenSize, 0), Quaternion.Euler(180, 0, 0));
    }

    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloudPrefab,new Vector3(Random.Range(-horizontalScreenSize, horizontalScreenSize), Random.Range(-verticalScreenSize, verticalScreenSize), 0), Quaternion.identity);
        }
    }

}
