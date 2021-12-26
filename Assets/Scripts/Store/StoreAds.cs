using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class StoreAds : MonoBehaviour, IUnityAdsListener
{
    [SerializeField] private string gameID;
    [SerializeField] private bool testMode;
    [SerializeField] private Money money;

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.AddListener(this);
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

    public void OnUnityAdsReady(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            money.AddMoney();
            print("Reward");
        }    
    }
}
