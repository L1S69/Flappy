using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LanguageButton : MonoBehaviour, IPointerClickHandler
{
	[SerializeField] private Image languageIcon;
	[SerializeField] private GameData gameData;
	
	private void Start()
	{
		languageIcon.sprite = gameData.LanguageSprite[PlayerPrefs.GetInt("Language")];
	}
	
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvents.ChangeLanguageButtonClickAction();
		languageIcon.sprite = gameData.LanguageSprite[PlayerPrefs.GetInt("Language")];
    }
}
