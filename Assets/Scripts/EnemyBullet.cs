using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    Rigidbody2D rbBullet;
    Transform parentTransform;

    public float speed;
    Vector2 direction;

    // Use this for initialization
    void Start()
    {
        rbBullet = GetComponent<Rigidbody2D>();
        rbBullet.velocity = (direction * speed); //inicializar la velocidad una sola vez
    }

    

    public void changeDirection(Vector2 vector ) //Recibe el vector de direccion de cada bala
    {
        direction = vector;
    }
    


}
