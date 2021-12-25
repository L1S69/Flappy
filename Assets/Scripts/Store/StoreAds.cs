using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class StoreAds : MonoBehaviour, IUnityAdsShowListener
{
    [SerializeField] private string gameID;
    [SerializeField] private bool testMode;
    [SerializeField] private Money money;

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameID, testMode);
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
        if (placementId.Equals("Rewarded_Android") && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            money.AddMoney();
        }
    }
}
