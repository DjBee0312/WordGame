using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnToMM : MonoBehaviour
{
    public Button Return;

    private void Update()
    {
        Return.onClick.AddListener(delegate { returnToMM(); });
    }

    public void returnToMM ()
    {
        SceneManager.LoadScene("Start Menu");
    }
}