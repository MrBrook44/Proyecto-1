using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") Destroy(this.gameObject);
    }

    //Cuando haya Game Manager hay que añadir puntos o subir un contador del colecionable
}