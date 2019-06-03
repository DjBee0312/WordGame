using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowRecords : MonoBehaviour
{
    public Button records;

    private void Update()
    {
        records.onClick.AddListener(delegate { ShowRecord(); });
    }

    void ShowRecord()
    {
        SceneManager.LoadScene("Records");
    }
}
