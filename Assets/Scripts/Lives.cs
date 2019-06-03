using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int lives = 3;
    public Text livesText;

    private void Update()
    {
        livesText.text = "Lives:" + lives;
    }

    public void DecreaseLives ()
    {
        lives--;
    }
}
