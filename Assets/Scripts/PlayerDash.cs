using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float speed, jumpForce, dashAcc;
    bool jump, dashing;
    float speedX, speedDash;
    Rigidbody2D rb;

    //Obtenemos el Rigidbody del jugador para modificar su velocidad
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //En el Update() declaramos los "controles" del jugador, para desplazarse en el eje X y para saltar en el eje Y
    void Update()
    {
        speedX = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown("s"))speedDash = speed * speedX;
        if (Input.GetKey("s")) dashing = true;
        else dashing = false;
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f) { jump = true; }
    }

    //Declaramos la velocidad del jugador en el eje X y en el eje Y
    void FixedUpdate()
    {
        //if (rb.velocity.x == 0) dashing = false;
        if (!dashing) rb.velocity = new Vector2(speed * speedX, rb.velocity.y);
        else
        {
            speedDash *= dashAcc;
            rb.velocity = new Vector2(speedDash, rb.velocity.y);
        }
        if (jump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
        }

    }
    static void Dash(Rigidbody2D rb, float dashForce, ref bool dashing)
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        rb.AddForce(new Vector2(dashForce,0), ForceMode2D.Impulse);
        dashing = false;
    }
}