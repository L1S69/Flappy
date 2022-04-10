using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkinScroller : MonoBehaviour
{
    [SerializeField] private Image skin;
	[SerializeField] private SkinsData skinsData;
	[SerializeField] private GameData gameData;
	[SerializeField] private TextMeshProUGUI selectButtonText;
	
	private int language;
	private string selectText;
	private string selectedText;

	private Money money;
	
	private int number;
	
	private void Start()
	{
		language = PlayerPrefs.GetInt("Language");
		
		selectText = gameData.SelectText[language];
		selectedText = gameData.SelectedText[language];
		
		PlayerPrefs.SetInt("AvailableSkins" + 0, 1);
		money = GetComponent<Money>();
		SetSkin(skinsData.Skins[0]);
		CheckPlayerChoise();
	}
	
	private void OnEnable()
	{
		GameEvents.LeftButtonClickAction += PreviousSkin;
		GameEvents.RightButtonClickAction += NextSkin;
		GameEvents.SelectButtonClickAction += SelectSkin;
	}

	private void OnDisable()
	{
		GameEvents.LeftButtonClickAction -= PreviousSkin;
		GameEvents.RightButtonClickAction -= NextSkin;
		GameEvents.SelectButtonClickAction -= SelectSkin;
	}

	private void SetSkin(Sprite sprite)
	{
		skin.sprite = sprite;
	}
	
	private void NextSkin()
	{
		if (number < skinsData.Skins.Length - 1) number++;
		else number = 0;
		SetSkin(skinsData.Skins[number]);
		CheckAvailability();
		CheckPlayerChoise();
	}
	
	private void PreviousSkin()
	{
		if (number > 0) number--;
		else number = skinsData.Skins.Length - 1;
		SetSkin(skinsData.Skins[number]);
		CheckAvailability();
		CheckPlayerChoise();
	}
	
	private void SelectSkin()
	{
		if (PlayerPrefs.GetInt("AvailableSkins" + number) == 1)
		{
			PlayerPrefs.SetInt("ChoosedSkin", number);
			selectButtonText.text = selectedText;
			selectButtonText.color = new Color32(124, 78, 255, 255);
		}
		else if (money.SpendMoney(skinsData.Prices[number]))
		{
			PlayerPrefs.SetInt("AvailableSkins" + number, 1);
			selectButtonText.text = selectText;
		}
		else 
		{
			print("Not enough money");
		}
	}

	private void CheckAvailability()
	{
		if (PlayerPrefs.GetInt("AvailableSkins" + number) == 1) selectButtonText.text = selectText;
		else selectButtonText.text = $"{skinsData.Prices[number]}";
	}

	private void CheckPlayerChoise()
	{
		if (PlayerPrefs.GetInt("ChoosedSkin") == number)
		{
			selectButtonText.text = selectedText;
			selectButtonText.color = new Color32(124, 78, 255, 255);
		}
		else 
		{
			selectButtonText.color = new Color32(227, 218, 255, 255);
			selectButtonText.text = selectText;
		}
	}
}
