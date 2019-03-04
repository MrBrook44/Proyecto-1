using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Text timer;
    public float maxSeconds;

    void Update()
    {
        timer.text = "Time: " + (int)maxSeconds; //solo se muestra la parte entera

        EverySecond();
    }
    void EverySecond ()
    {
        if (maxSeconds > 0)
        {
            maxSeconds -= Time.deltaTime;
        }
    }
}

