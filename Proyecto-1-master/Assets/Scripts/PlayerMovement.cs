using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed, jumpForce;
    bool jump;
    float speedX;
    Rigidbody2D rb;

    //Obtenemos el Rigidbody del jugador para modificar su velocidad
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //En el Update() declaramos los "controles" del jugador, para desplazarse en el eje X y para saltar en el eje Y
    void Update()
    {
        //speedX = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.D)) rb.velocity = new Vector2(speed, rb.velocity.y);
        else if (Input.GetKey(KeyCode.A)) rb.velocity = new Vector2(-speed, rb.velocity.y);
      
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f) { jump = true; }
    }

    //Declaramos la velocidad del jugador en el eje X y en el eje Y
    void FixedUpdate()
    {
        if (jump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
        }

    }
}