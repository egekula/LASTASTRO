using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class AdManager : MonoBehaviour
{
    private InterstitialAd interstitial;

    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1156674991958754/4095814601";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
    public void ShowInterstitial()
    {
            if (PlayerPrefs.GetInt("Noads") == 0)
            { 
                    if (this.interstitial.IsLoaded()) {
                            this.interstitial.Show();
                    }
            }
            
    }

    public void OnDestroy()
    {
            if (interstitial != null)
            {
                    interstitial.Destroy();
            }
    }
}
