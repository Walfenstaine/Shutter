using UnityEngine;
using InstantGamesBridge;
using InstantGamesBridge.Modules.Advertisement;
using pEventBus;




public class ShowInter : MonoBehaviour, IEventReceiver<ShowInterAds>
{
    public AudioSource sorse;
    public Data data;
    
    void Start()
    {
        Bridge.advertisement.interstitialStateChanged += Interstitial;
        EventBus.Register(this);

        EventBus<ShowInterAds>.Raise(new ShowInterAds()
        {

        });
    }

    void OnDestroy()
    {
        Bridge.advertisement.interstitialStateChanged -= Interstitial;
        EventBus.UnRegister(this);
    }

    void Awake()
    {
        Showreklame();
    }
    public void Showreklame()
    {
        var ignoreDelay = false;
        Bridge.advertisement.ShowInterstitial(ignoreDelay, success =>
        {

        });
    }

    public void OnEvent(ShowInterAds e)
    {
        var ignoreDelay = false;
        Bridge.advertisement.ShowInterstitial(ignoreDelay, success =>
        {

        });
    }

    private void Interstitial(InterstitialState state)
    {
        if (state == InterstitialState.Closed)
        {
            sorse.mute = !data.soundOn;
        }


        if (state == InterstitialState.Opened)
        {
            sorse.mute = true;
        }
    }
}