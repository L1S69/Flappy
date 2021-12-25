using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RestartTextController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI restartText;
    [SerializeField] private GameData gameData;

    private int language;

    void Start()
    {
        language = PlayerPrefs.GetInt("Language");
        restartText.text = gameData.RestartText[language];
    }
}
