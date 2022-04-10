using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuTextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playButtonText;
	[SerializeField] private TextMeshProUGUI shopButtonText;
	[SerializeField] private GameData gameData;
	
	private int language;
	
    void Start()
    {
        language = PlayerPrefs.GetInt("Language");
		SetLanguage(language);
    }
	
	private void OnEnable()
	{
		GameEvents.ChangeLanguageButtonClickAction += ChangeLanguage;
	}
	
	private void OnDisable()
	{
		GameEvents.ChangeLanguageButtonClickAction -= ChangeLanguage;
	}

    private void SetLanguage(int i)
    {
        playButtonText.text = gameData.PlayButtonText[i];
		shopButtonText.text = gameData.ShopButtonText[i];
    }
	
	private void ChangeLanguage()
	{
		if(language == 0)
		{
			language = 1;
		} else if (language == 1)
		{
			language = 2;
		} else if (language == 2)
		{
			language = 0;
		}
		
		SetLanguage(language);
	}
}
