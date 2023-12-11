using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public string Player_name;
    public string saveName;
    public TMP_Text inputText;
    public TMP_Text loadedName;

    void Update()
    {
        Player_name = PlayerPrefs.GetString("name", "none");
        loadedName.text = "Hi, " + Player_name + "!";
    }

    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}
