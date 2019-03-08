using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOnTrigger : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            print("YOU WIN!!");
        }
    }

    // llamara al GM y avisará de la victoria
}
