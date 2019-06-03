using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour
{
    static string list = File.ReadAllText("Assets/files/WordList.ψna");

    public static string[] wordList = list.Split(' ');
    //public static string[] wordList = { "small", "love", "house" };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
