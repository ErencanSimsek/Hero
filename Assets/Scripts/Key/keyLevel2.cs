using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class keyLevel2 : MonoBehaviour
{
    [SerializeField]
    GameObject KeyButton;
    public static bool level_2 = false;

#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
  private string _adUnitId = "unused";
#endif
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        LoadInterstitialAd();
    }

    void Update()
    {
        if (Key.key == 1)
        {
            KeyButton.SetActive(true);
        }
        if (keyLevel1.home == 1)
        {
            level_2 = true;
            KeyButton.SetActive(false);
            if (interstitialAd != null && interstitialAd.CanShowAd())
            {
                interstitialAd.Show();
            }
        }
    }


    private InterstitialAd interstitialAd;

    public void LoadInterstitialAd()
    {
        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        Debug.Log("Loading the interstitial ad.");

        // create our request used to load the ad.
        var adRequest = new AdRequest();
        adRequest.Keywords.Add("unity-admob-sample");

        // send the request to load the ad.
        InterstitialAd.Load(_adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
              // if error is not null, the load request failed.
              if (error != null || ad == null)
                {
                    return;
                }
                interstitialAd = ad;
                RegisterReloadHandler(interstitialAd);
            });
        
    }

    private void RegisterReloadHandler(InterstitialAd ad)
    {
        ad.OnAdFullScreenContentClosed += () =>
        {
            SceneManager.LoadScene("Level");
            interstitialAd.Destroy();
            LoadInterstitialAd();
        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            interstitialAd.Destroy();
            LoadInterstitialAd();
        };
    }
}
