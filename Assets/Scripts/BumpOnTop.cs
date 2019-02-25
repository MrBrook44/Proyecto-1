using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpOnTop : MonoBehaviour
{

    //cuando el jugador salte sobre este objeto, lo destruirá
    private void OnCollisionEnter2D(Collision2D other)
    {
        //el jugador tiene que tener un componente PlayerMovement (para que solo pueda ser el jugador)
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            //buscamos la normal y calculamos el ángulo entre la normal y el vector Up
            ContactPoint2D contact = other.contacts[0];
            float angle = Vector2.Angle(contact.normal, transform.up);

            //si el ángulo es de unos 180º (el jugador cae verticalmente), destruye al enemigo
            if (Mathf.Approximately(angle, 180))
            {
                Destroy(this.gameObject);
            }

        }
    }
}