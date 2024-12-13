using UnityEngine;
using GoogleMobileAds.Api;



public class AdsManager : MonoBehaviour
{
#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
  private string _adUnitId = "unused";
#endif
    private void Start()
    {
        MobileAds.Initialize(initStatus => { });
    }
}


