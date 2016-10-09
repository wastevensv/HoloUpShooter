using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour
{
    int score = 0;
    public TextMesh label;
    bool gameActive = true;

    void Update()
    {
        label.text = "Score: " + score;
    }

    void ScoreUp()
    {
        if(gameActive) score++;
    }

    void GameOver()
    {
        gameActive = false;
    }
}
