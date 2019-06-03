using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Button startButton;
    public InputField playerName;


    private void Start()
    {
        InputField input = playerName;
        var se = new InputField.SubmitEvent();
    }

    private void Update()
    {
        playerName.onEndEdit.AddListener(delegate { checkLength(playerName); });
        print(playerName.text);
        playerName.onEndEdit.AddListener(delegate { SetName(playerName.text); });
        startButton.onClick.AddListener(delegate { StartGame(); });
    }

    public void checkLength(InputField name)
    {
        if(name.text.Length >= 1)
        {
            ActivateButton();
        } 
        else
        {
            DeactivateButton();
        }
    }

    void SetName (string name)
    {
        PlayerPrefs.SetString("name", name);
    }

    public void ActivateButton()
    {
        startButton.interactable = true;
    }

    public void DeactivateButton()
    {
        startButton.interactable = false;
    }

    void StartGame ()
    {
        SceneManager.LoadScene("Main");
    }
}
