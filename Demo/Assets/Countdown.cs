using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    // The current time of the countdown timer.
    float currentTime = 0f;

    // The starting time of the countdown timer.
    float startingTime = 100f;

    // The end time of the countdown timer.
    float Endtime = 0f;

    // The UI element that displays the current time of the countdown timer.
    public Text countdownText;

    void Start()
    {
        // Initialize the current time to the starting time.
        currentTime = startingTime;
    }

    void Update()
    {
        // Decrement the current time by the delta time.
        currentTime -= 1 * Time.deltaTime;

        // Display the current time in the countdown text UI element.
        countdownText.text = currentTime.ToString();
    }

    void End()
    {

    }
}
