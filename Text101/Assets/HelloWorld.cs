using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelloWorld : MonoBehaviour
{
     int Min = 1;
     int Max = 1000;
     int Guess;
     int Level = 1;

    // Start is called before the first frame update
    void Start()
    {
        PrintUpdate();
        Max = Max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the down arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Max = Guess;
            PrintUpdate();
        }  
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Min = Guess;
            PrintUpdate();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            StartANewGame();
        }
    }

    void PrintUpdate()
    {
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick an number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is : " + Max);
        Debug.Log("The lowest number you can pick is : " + Min);

        int OurGuess = (Min + Max) / 2;
        Guess = OurGuess;

        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    void StartANewGame()
    {
        Min = 1;
        Max = 1000;
        Level++;
        Debug.Log("Bravo************************************** Level" + Level);
        PrintUpdate();
        Max = Max + 1;
    }
}
