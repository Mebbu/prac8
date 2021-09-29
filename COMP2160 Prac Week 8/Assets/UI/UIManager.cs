using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    
    [SerializeField]
    private string scoreFormat = "Score: {0}";

    private Scorekeeper scorekeeper;

    void Start()
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();
    }


    void Update()
    {
        int score = scorekeeper.Score;
        scoreText.text = string.Format(scoreFormat, score);
    }
}
