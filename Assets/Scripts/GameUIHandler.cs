using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIHandler : MonoBehaviour
{
    public TextMeshProUGUI PlayerNameText;

    public void Start()
    {
        if (MainManager.instance != null)
        {
            MainManager.instance.LoadUserData();
            PlayerNameText.text = "Welcome to the range Private " + MainManager.instance.PlayerName;

        }
    }
}
