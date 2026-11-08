using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;

    public TextMeshProUGUI scoreText;

    public void Start()
    {
        scoreText.text = ": " + ScoreManager.score.ToString();

    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
    }



}


