//Taylor Burdgess, Charlie Garrido

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TASK 1: As the first task, have a "Score: " text on the screen and update it to show the current score value.

public class GameManager : MonoBehaviour
{
   //Score variable
   private int score = 0;
   private Text scoreText;

   void Start()
   {
    UpdateScoreText();
   }

   public void AddScore(int points)
   {
    score += points;
    UpdateScoreText;
   }

   void UpdateScoreText()
   {
    if(scoreText !=null)
    {
     scoreText.text = "Score: " + score; 
    }
   }


}