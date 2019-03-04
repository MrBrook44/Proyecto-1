using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerDead dead = collision.GetComponent<PlayerDead>(); //Comprobar si el colisionado lleva el script PlayerDead, si es cierto,llama el metodo PlayerOnDead del script.
            if (dead)
            {
                dead.PlayerOnDead();      //para desactivar el gameObject
                                          // dead.Respawn();       //Para resetear posicion
            }
        }

    }
}
