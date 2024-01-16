using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using pEventBus;
using UnityEngine;
using UnityEngine.Events;
public class Load : MonoBehaviour, IEventReceiver<OnLoadIsComplete>
{
    public Data data;
    public UnityEvent touch, resed;
    public void Staring()
    {
        SceneManager.LoadScene(1);
        data.record = 0;
        data.level = "Scene1";
    }
    public void Loading()
    {
        SceneManager.LoadScene(data.level);
    }
    public void OnEvent(OnLoadIsComplete e)
    {
        touch.Invoke();
    }

    void Start()
    {
        EventBus.Register(this);
        SaveAndLoad.Instance.Load();
        if (data.record == 0)
        {
            resed.Invoke();
        }
    }

    private void OnDestroy()
    {
        EventBus.UnRegister(this);
    }
}
