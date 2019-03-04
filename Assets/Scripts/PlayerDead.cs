using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour {
    /*
    public Transform resetP;

    public void Respawn()
    {
        transform.position = resetP.position;       //Poner la posicion del sprite en la posicion de respawn.
    }
    */


    public void PlayerOnDead()
    {
        this.gameObject.SetActive(false); // Desactivar el gameObject del sprite con este funcion
    }

}
