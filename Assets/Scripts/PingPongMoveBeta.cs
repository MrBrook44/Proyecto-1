using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMoveBeta : MonoBehaviour {

    public Transform pointB;
    public float speed;
    private Vector2 initialPos;
    private Vector2 finalPos;
    private Vector2 dir;
    int state;
   //Rigidbody2D rb;



    void Start()
    {
        initialPos = transform.position;
        finalPos = pointB.position;
        state = GetState(initialPos,finalPos);
        dir = new Vector2(finalPos.x - initialPos.x, finalPos.y - initialPos.y);
        //rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (ChangeSpeed(initialPos,finalPos,transform.position,state))
        {
            speed *= -1;
        }
        transform.Translate(speed * Time.deltaTime * dir.normalized);
        //rb.velocity = speed * dir.normalized;
    }

    
    static bool ChangeSpeed(Vector2 a, Vector2 b, Vector2 position, int state)
    {
        switch (state)
        {
            case (1):
                {
                    if ((position.x < b.x && position.y > b.y) || (position.x > a.x && position.y < a.y)) return true;
                    return false;
                }
            case (2):
                {
                    if ((position.x < b.x && position.y < b.y) || (position.x > a.x && position.y > a.y)) return true;
                    return false;
                }
            case (3):
                {
                    if ((position.x > b.x && position.y > b.y) || (position.x < a.x && position.y < a.y)) return true;
                    return false;
                }
            case (4):
                {
                    if ((position.x > b.x && position.y < b.y) || (position.x < a.x && position.y > a.y)) return true;
                    return false;
                }
            case (5):
                {
                    if ( position.y < b.y || position.y > a.y) return true;
                    return false;
                }
            case (6):
                {
                    if (position.y > b.y || position.y < a.y) return true;
                    return false;
                }
            case (7):
                {
                    if (position.x > b.x || position.x < a.x) return true;
                    return false;
                }
            case (8):
                {
                    if (position.x < b.x || position.x > a.x) return true;
                    return false;
                }
            case (9):
                {
                    return false;
                }
        }
        return true;
    }
    static int GetState(Vector2 a, Vector2 b)
    {
        if (a.x > b.x && a.y < b.y) { return 1; }
        if (a.x > b.x && a.y > b.y) { return 2; }
        if (a.x < b.x && a.y < b.y) { return 3; }
        if (a.x < b.x && a.y > b.y) { return 4; }
        if (a.x == b.x && a.y > b.y) { return 5; }
        if (a.x == b.x && a.y < b.y) { return 6; }
        if (a.x < b.x && a.y == b.y) { return 7; }
        if (a.x > b.x && a.y == b.y) { return 8; }
        return 9;
    }

}
