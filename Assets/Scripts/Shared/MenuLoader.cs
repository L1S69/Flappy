using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    private void OnEnable()
	{
		GameEvents.BackButtonClickAction += LoadMenu;
	}
	
	private void OnDisable()
	{
		GameEvents.BackButtonClickAction -= LoadMenu;
	}
	
	private void LoadMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
