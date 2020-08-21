using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextComponent;

    [SerializeField] int Min;
    [SerializeField] int Max;
    int Guess;

    public void LoadNextScene()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void SetHigher()
    {
        if (Guess < Max)
        {
            Min = Guess + 1;
        }
        CalculateGuess();
    }

    public void SetLower()
    {
        if (Guess > Min)
        {
            Max = Guess - 1;
        }
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        //int OurGuess = (Min + Max) / 2;

        int OurGuess = Random.Range(Min, Max + 1);
        Guess = OurGuess;
        TextComponent.text = Guess.ToString();
    }

    void Start()
    {
        CalculateGuess();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}