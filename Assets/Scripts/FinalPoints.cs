using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class FinalPoints : MonoBehaviour
{
    [SerializeField]
    Text finalScore;
    string score;
    string name;
    string fileName = "Assets/files/records.ψna";

    public void Start()
    {
        name = PlayerPrefs.GetString("name");
        score = PlayerPrefs.GetFloat("points").ToString();
        finalScore.text = name + ", your Score:" + score;
        AddNewRecord();
        //print(finalScore.text);
    }

    void AddNewRecord ()
    {
        string newScore = score + "|" + name + " ";
        File.AppendAllText(fileName, newScore);
    }

}
