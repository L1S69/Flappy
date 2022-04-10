using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void OnEnable()
	{
		GameEvents.PlayButtonClickAction += LoadGame;
		GameEvents.StoreButtonClickAction += LoadStore;
	}
	
	private void OnDisable()
	{
		GameEvents.PlayButtonClickAction -= LoadGame;
		GameEvents.StoreButtonClickAction -= LoadStore;
	}
	
	private void LoadGame()
	{
		SceneManager.LoadScene("Game");
	}
	
	private void LoadStore()
	{
		SceneManager.LoadScene("Store");
	}
}
