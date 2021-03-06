using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreTextPlayer1;
    [SerializeField]
    private Text scoreTextPlayer2;
    
    [SerializeField]
    private string scoreFormat = "Score: {0}";

    private Scorekeeper scorekeeper;

    void Start()
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();
    }


    void Update()
    {
        //int score = scorekeeper.Score1;
        scoreTextPlayer1.text = string.Format(scoreFormat, scorekeeper.Score1);
        //int score = scorekeeper.Score2;
        scoreTextPlayer2.text = string.Format(scoreFormat, scorekeeper.Score2);
    }
}
