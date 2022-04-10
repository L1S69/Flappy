using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameScriptableObject", order = 1)]
public class GameData : ScriptableObject
{
	public Sprite[] LanguageSprite;
	public string[] PlayButtonText;
	public string[] ShopButtonText;
	
	public string[] SelectText;
	public string[] SelectedText;

	public string[] RestartText;
}
