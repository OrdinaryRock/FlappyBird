using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class GlobalVar
{
    public static int score;
    public static int highScore;

    public static void SetScore()
    {
        PlayerPrefs.SetInt("highscore", highScore);
    }

    public static void GetScore()
    {
        highScore = PlayerPrefs.GetInt("highscore");
    }
}
