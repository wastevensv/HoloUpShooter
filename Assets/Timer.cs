using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public TextMesh label;
    public float timeRemaining = 60f;

    void StartTimer()
    {
        InvokeRepeating("decreaseTimeRemaining", 1.0f, 1.0f);
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            label.text = timeRemaining.ToString();
        } else
        {
            label.text = "Times up!";
            SendMessageUpwards("TimerEnd");
        }
    }

    void decreaseTimeRemaining()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= 1;
        }
    }
}
