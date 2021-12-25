using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsController : MonoBehaviour
{
    [SerializeField] private string gameID;
    [SerializeField] private bool testMode;

    private int gameOverCount;
    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameID, testMode);
        }

        gameOverCount = PlayerPrefs.GetInt("GameOverCount");
    }

    private void OnEnable()
    {
        GameEvents.GameOverAction += AddCount;
    }

    private void OnDisable()
    {
        GameEvents.GameOverAction -= AddCount;
    }

    private void ShowAd()
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Show("Interstitial_Android");
        }
        gameOverCount = 0;
        PlayerPrefs.SetInt("GameOverCount", gameOverCount);
    }

    private void AddCount() 
    {
        gameOverCount++;
        PlayerPrefs.SetInt("GameOverCount", gameOverCount);
        if (gameOverCount >= 5) 
        {
            ShowAd();
        }
    }
}
