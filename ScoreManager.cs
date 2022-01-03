using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        score = 0;
    }

    public void ChangeScore(int metalNutpoints)
    {
        score += metalNutpoints;
        text.text = ": " + score.ToString();
    }
}

