using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public Text timer;
    public float maxSeconds;
	
	// Update is called once per frame
	void Update () {

        maxSeconds -= Time.deltaTime; //dismnuye el tiempo en cada update
        timer.text = "Time: " + (int)maxSeconds; //solo se muestra la parte entera
        
        EverySecond();
	}

    
}
