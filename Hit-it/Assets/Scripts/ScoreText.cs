using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Scoring system and score text shown through canvas
    public static int score;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //after hitting with collision, it get the text component to show text
        scoreText = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //updating the score until the game is not over
        scoreText.text = "Score: " + score;
    }
}
