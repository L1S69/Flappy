using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageController : MonoBehaviour
{
	[SerializeField]private int language;
	
    private void Start()
    {
        language = PlayerPrefs.GetInt("Language");
    }

    private void OnEnable()
	{
		GameEvents.ChangeLanguageButtonClickAction += ChangeLanguage;
	}
	
	private void OnDisable()
	{
		GameEvents.ChangeLanguageButtonClickAction -= ChangeLanguage;
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
		
		PlayerPrefs.SetInt("Language", language);
	}
}
