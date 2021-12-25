using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class StoreAds : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] private string gameID;
    [SerializeField] private bool testMode;
    [SerializeField] private Money money;

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameID, testMode, this);
            StartCoroutine(ShowBannerWhenReady());
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        }
    }

    private void OnEnable()
    {
        GameEvents.AddMoneyButtonClickAction += ShowRewardedAd;
    }

    private void OnDisable()
    {
        GameEvents.AddMoneyButtonClickAction -= ShowRewardedAd;
    }

    private void ShowRewardedAd() 
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Show("Rewarded_Android");
        }
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show("Banner_Android");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        if (showCompletionState == UnityAdsShowCompletionState.COMPLETED)
        {
            money.AddMoney();
            print("Reward");
        }
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnInitializationComplete()
    {
        throw new System.NotImplementedException();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        throw new System.NotImplementedException();
    }
}
