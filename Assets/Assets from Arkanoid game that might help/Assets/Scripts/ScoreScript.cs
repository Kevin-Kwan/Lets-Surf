using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    public static int highestScoreValue = 0;
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {if (highestScoreValue<=scoreValue)
        {
            highestScoreValue = scoreValue;
        }
        score.text = "Score: " + scoreValue+ "\nHighest \nScore: " + highestScoreValue;
    }
}
