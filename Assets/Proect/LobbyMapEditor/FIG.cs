using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIG : MonoBehaviour
{
    private int i;
    public GameObject hhru;
    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(0, 50);
        switch (i)
        {
            case 0:
                hhru.SetActive(false);
                break;
            case 1:
                hhru.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
