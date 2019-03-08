using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour {


    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerDead playerDead = collision.gameObject.GetComponent<PlayerDead>();
            if (playerDead)
            {
                playerDead.PlayerOnDead();
                Destroy(this.gameObject);
            }

        }
        else
            Destroy(this.gameObject);   // poniendo que todos los colisionado hace destruir a la bala, entonce hay que tener con cuidado la mascara de colision,
        // solo seleccionando el floor y player para evitar que desaparece la bala al chocar entre si o con la camara
    }
}
