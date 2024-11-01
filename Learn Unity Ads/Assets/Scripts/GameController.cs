using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameMenu;

    private void Start()
    {
        mainMenu.SetActive(true);
        gameMenu.SetActive(false);
    }

    public void ClickPlay()
    {
        AdsManager.instance.ShowInterstitialAd();
        mainMenu.SetActive(false);
        gameMenu.SetActive(true);
    }

    public void ClickBack()
    {
        AdsManager.instance.ShowInterstitialAd();
        mainMenu.SetActive(true);
        gameMenu.SetActive(false);
    }

    public void ShowRewaredAd()
    {
        AdsManager.instance.ShowRewardedAd();
    }
}
