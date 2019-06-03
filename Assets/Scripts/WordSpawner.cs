using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{

    public GameObject wordPref;
    public Transform wordCanvas;
    public GameObject ScorePref;

    private void Start()
    {
        GameObject ScoreObj = Instantiate(ScorePref, new Vector3(80, -15, 0), Quaternion.identity, wordCanvas);
    }

    public WordDisplay SpawnWord ()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-7.5f, 7.5f), 6.5f);

        GameObject wordObj = Instantiate(wordPref,randomPosition,Quaternion.identity,wordCanvas); 
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
        return wordDisplay;
    }
}
