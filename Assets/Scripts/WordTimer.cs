using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public ManagerWord wordManager;

    public float spawntime = 1.5f;
    private float nextWord = 0f;

    private void Update()
    {
        if(Time.time >= nextWord)
        {
            wordManager.AddWord();
            nextWord = Time.time + spawntime;
            spawntime *= 0.99f;
        }
    }
}
