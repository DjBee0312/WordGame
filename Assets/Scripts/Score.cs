using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public float points;//ur points
    public float timer = 0f;//time from start printing
    int length;//length of current word
    public MyIntEvent observer;//my observer

    private void Awake()
    {
        PlayerPrefs.SetFloat("points", points);

        if (observer == null)
            observer = new MyIntEvent();
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

        observer.Invoke((int)points);

        PlayerPrefs.SetFloat("points", points);
    }
}
