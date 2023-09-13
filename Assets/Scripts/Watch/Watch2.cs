using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class Watch2 : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    GameObject Play, Pause, dieMenu, left, right, up, Player, Music, DieMusic;
    [SerializeField]
    GameObject Levha1, Levha2, Levha3, Levha4, Levha5, Levha6, Levha7, Levha8, Levha9, Levha10, Levha11, Levha12, Levha13, Levha14, Levha15, Levha16, Levha17, Levha18, Levha19, Levha20, Levha21, Levha22;
    bool reklam = false;
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        LoadRewardedAd();
    }

    // These ad units are configured to always serve test ads.
#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
  private string _adUnitId = "unused";
#endif

    private RewardedAd rewardedAd;

    /// <summary>
    /// Loads the rewarded ad.
    /// </summary>
    public void LoadRewardedAd()
    {
        // Clean up the old ad before loading a new one.
        if (rewardedAd != null)
        {
            rewardedAd.Destroy();
            rewardedAd = null;
        }

        Debug.Log("Loading the rewarded ad.");

        // create our request used to load the ad.
        var adRequest = new AdRequest();
        adRequest.Keywords.Add("unity-admob-sample");

        // send the request to load the ad.
        RewardedAd.Load(_adUnitId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
                // if error is not null, the load request failed.
                if (error != null || ad == null)
                {
                    return;
                }

                rewardedAd = ad;
                RegisterReloadHandler(rewardedAd);
            });
        
    }

    public void ShowRewardedAd()
    {
        const string rewardMsg =
            "Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {
                // TODO: Reward the user.
                Debug.Log(String.Format(rewardMsg, reward.Type, reward.Amount));

                Hero.heroCan = 1;
                Time.timeScale = 1f;
                Play.SetActive(true);
                Pause.SetActive(false);
                left.SetActive(true);
                right.SetActive(true);
                up.SetActive(true);
                dieMenu.SetActive(false);
                Hero.move = false;
                animator.SetBool("walk", false);
                Music.GetComponent<AudioSource>().enabled = true;
                Player.GetComponent<AudioSource>().enabled = true;
                if (kayit2Noktasi20.level2KayitNoktasi == 1)
                {
                    Player.transform.position = new Vector3(Levha1.transform.position.x, Levha1.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 2)
                {
                    Player.transform.position = new Vector3(Levha2.transform.position.x, Levha2.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 3)
                {
                    Player.transform.position = new Vector3(Levha3.transform.position.x, Levha3.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 4)
                {
                    Player.transform.position = new Vector3(Levha4.transform.position.x, Levha4.transform.position.y + 3f);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 5)
                {
                    Player.transform.position = new Vector3(Levha5.transform.position.x, Levha5.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 6)
                {
                    Player.transform.position = new Vector3(Levha6.transform.position.x, Levha6.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 7)
                {
                    Player.transform.position = new Vector3(Levha7.transform.position.x, Levha7.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 8)
                {
                    Player.transform.position = new Vector3(Levha8.transform.position.x, Levha8.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 9)
                {
                    Player.transform.position = new Vector3(Levha9.transform.position.x, Levha9.transform.position.y + 3f);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 10)
                {
                    Player.transform.position = new Vector3(Levha10.transform.position.x, Levha10.transform.position.y + 3f);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 11)
                {
                    Player.transform.position = new Vector3(Levha11.transform.position.x, Levha11.transform.position.y + 3f);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 12)
                {
                    Player.transform.position = new Vector3(Levha12.transform.position.x, Levha12.transform.position.y + 3f);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 13)
                {
                    Player.transform.position = new Vector3(Levha13.transform.position.x, Levha13.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 14)
                {
                    Player.transform.position = new Vector3(Levha14.transform.position.x, Levha14.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 15)
                {
                    Player.transform.position = new Vector3(Levha15.transform.position.x, Levha15.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 16)
                {
                    Player.transform.position = new Vector3(Levha16.transform.position.x, Levha16.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 17)
                {
                    Player.transform.position = new Vector3(Levha17.transform.position.x, Levha17.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 18)
                {
                    Player.transform.position = new Vector3(Levha18.transform.position.x, Levha18.transform.position.y + 3f);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 19)
                {
                    Player.transform.position = new Vector3(Levha19.transform.position.x, Levha19.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 20)
                {
                    Player.transform.position = new Vector3(Levha20.transform.position.x, Levha20.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 21)
                {
                    Player.transform.position = new Vector3(Levha21.transform.position.x, Levha21.transform.position.y);
                }
                else if (kayit2Noktasi20.level2KayitNoktasi == 22)
                {
                    Player.transform.position = new Vector3(Levha22.transform.position.x, Levha22.transform.position.y);
                }
                painmenufind.yanma++;
            });
        }
    }

    private void RegisterReloadHandler(RewardedAd ad)
    {
        // Raised when the ad closed full screen content.
        ad.OnAdFullScreenContentClosed += () =>
        {
            rewardedAd.Destroy();
            Debug.Log("Rewarded Ad full screen content closed.");

            // Reload the ad so that we can show another as soon as possible.
            LoadRewardedAd();
        };
        // Raised when the ad failed to open full screen content.
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            rewardedAd.Destroy();
            Debug.LogError("Rewarded ad failed to open full screen content " +
                           "with error : " + error);

            // Reload the ad so that we can show another as soon as possible.
            LoadRewardedAd();
        };
    }
}
