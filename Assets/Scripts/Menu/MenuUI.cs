using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Image skin;
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private SkinsData skinsData;
    void Start()
    {
        int choosed = PlayerPrefs.GetInt("ChoosedSkin");
        skin.sprite = skinsData.Skins[choosed];
        int highscore = PlayerPrefs.GetInt("Highscore");
        int money = PlayerPrefs.GetInt("Money");
        highscoreText.text = $"{highscore}";
        moneyText.text = $"{money}";
    }
}
