using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    CutsceneTransition cutsceneTransition = new CutsceneTransition();

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                
                timeRemaining = 0;
                timerIsRunning = false;

                // To Dessert Scene
                cutsceneTransition.changeScene(2, false);
            }
        }
    }
}