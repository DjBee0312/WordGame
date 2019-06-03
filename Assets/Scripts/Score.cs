using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float points;
    public float timer = 0f;
    int length;
    public Text score;
    public Transform wordCanvas;

    private void Start()
    {
        PlayerPrefs.SetFloat("points", points);
    }

    public void SetStartTime()
    { 
        timer = Time.time;
    }

    public float GetTime ()
    {
        float finishTime = Time.time;
        return finishTime - timer;
    }

    public void GetWordLength (string word)
    {
        length = word.ToCharArray().Length;
        print(length + " length");
    }

    public void increasePoints ()
    {
        points += Mathf.Round(length / GetTime());
        PlayerPrefs.SetFloat("points", points);
    }
}
