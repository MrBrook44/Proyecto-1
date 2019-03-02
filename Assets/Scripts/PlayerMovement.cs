using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed, jumpForce;
    float speedX;
    bool jump;
    Rigidbody2D rb;

    //Obtenemos el Rigidbody del jugador para modificar su velocidad
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //En el Update() declaramos los "controles" del jugador, para desplazarse en el eje X y para saltar en el eje Y
    void Update()
    {
        //solo se podrá mover con los botones a y d, editado desde el InputManager
        speedX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f) { jump = true; }
    }

    //Declaramos la velocidad del jugador en el eje X y en el eje Y
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * speedX, rb.velocity.y);

        if (jump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
        }

    }
}