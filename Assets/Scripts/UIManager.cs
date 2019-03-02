using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public Text timer;
    public float maxSeconds;
	
	// Update is called once per frame
	void Update () {
        timer.text = "Time: " + (int)maxSeconds;
        
        EverySecond();
	}

    //cosas que pasen una vez cada segundo
    void EverySecond()
    {
        if (maxSeconds > 0)
        {

            //el tiempo decrece en una unidad
            maxSeconds -= Time.deltaTime;
        }

    }

    
}
