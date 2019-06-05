using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        MyIntEvent observer = FindObjectOfType<Score>().observer;
        observer.AddListener(SetScore);
    }

    void SetScore(int points)
    {
        score.text = "Score:" + points;
    }
}
