using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coins;

    public GameObject coinPrefab;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //coins = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //gameManager.ChangeScoreText(coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            
            gameManager.AddCoins(1);            
            Destroy(gameObject);
        }
    }

        
    
}
