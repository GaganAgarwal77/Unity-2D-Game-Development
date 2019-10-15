using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max ;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to the Number Wizard.");
        Debug.Log("Go Ahead and Pick a Number in your mind.");
        Debug.Log("The Maximum number you can choose is: " + max);
        Debug.Log("The Minimum is: " + min);
        Debug.Log("Tell Me if my number is higher or lower than: " + guess);
        Debug.Log("Push Up => Higher, Push Down => Lower, Push Enter => Correct");
        max = max + 1 ;
    }
    void Nextguess()
    {
     Debug.Log("Is your number higher than my guess of : " + guess);
    }
     

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Nextguess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Nextguess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Our Guess is correct!");
            Debug.Log("Your number is: " + guess);
            StartGame();
        }

    }
}
