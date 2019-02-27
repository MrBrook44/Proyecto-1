using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PingPongMovement : MonoBehaviour
{

    public float Speed = 1;

    public Transform objective;

    private Vector2 initialPos;
    private Vector2 direc;

    // Use this for initialization
    void Start()
    {
        initialPos = new Vector2(transform.position.x, transform.position.y);
        if (initialPos.x < objective.position.x) 
        {
            direc = new Vector2(objective.position.x - transform.position.x, objective.position.y - transform.position.y);
        }
        else direc = new Vector2(transform.position.x - objective.position.x, transform.position.y - objective.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < objective.position.y)
        {
            if ((transform.position.x <= initialPos.x && transform.position.y <= initialPos.y) ||
            (transform.position.x >= objective.position.x && transform.position.y >= objective.position.y) ) direc *= -1;

            transform.Translate(direc.normalized * Speed * Time.deltaTime);
        }
    }
}
