using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    private static Scorekeeper instance;

    public static Scorekeeper Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private int points = 10;

    private int score1 = 0;

    //private int score2 = 0;

    public int Score1 
    {
        get { return score1; }
    }

    // public int Score2 
    // {
    //     get { return score2; }
    // }



    public void Start()
    {
        instance = this;
    }

    public void AddPoints()
    {
        score1 += points;
    }

    // public void AddPointsPlayer2()
    // {
    //     score2 += points;
    // }

    public void ResetScore()
    {
        score1 = 0;
    }
}
