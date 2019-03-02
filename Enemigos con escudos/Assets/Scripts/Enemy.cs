using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool leftShield, rightShield, topShield;
    public GameObject shield;
    public GameObject helmet;
    private Transform trf;

    void Start()
    {
        trf = GetComponent<Transform>();
        EquipShield(leftShield, rightShield, topShield);
    }

    private void EquipShield(bool left, bool right, bool top)
    {
        if (top)
        {
            GameObject newHelmet;
            newHelmet = Instantiate(helmet, new Vector2(transform.position.x, transform.position.y + transform.localScale.y), Quaternion.identity, trf);
            newHelmet.transform.Rotate(new Vector3(0, 0, 0));
        }
        if (left)
        {
            GameObject newShield;
            newShield = Instantiate(shield, new Vector2(transform.position.x - transform.localScale.x, transform.position.y), Quaternion.identity, trf);
            newShield.transform.Rotate(new Vector3(0, 0, -90));
        }
        if (right)
        {
            GameObject newShield;
            newShield = Instantiate(shield, new Vector2(transform.position.x + transform.localScale.x, transform.position.y), Quaternion.identity, trf);
            newShield.transform.Rotate(new Vector3(0, 0, 90));
        }
    }
}