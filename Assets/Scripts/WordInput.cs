using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{

    public ManagerWord wordManager;

    void Update()
    {
        foreach(char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
            print(letter);
        }
    }
}
