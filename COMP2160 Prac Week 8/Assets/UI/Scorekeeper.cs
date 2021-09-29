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

    private int score = 0;

    private int highscore = 0;

    public int Score 
    {
        get { return score; }
    }


    public void Start()
    {
        instance = this;
    }

    public void AddPoints()
    {
        score += points;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
