
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
public RigidBody2D rigibody2D;
public float bulletSpeed = 6;
{
    // Start is called before the first frame update
    void Start()
    {
        rigibody2D = GetComponent<RigidBody2D>()
        rigibody2D.AddForce(tranform.righ * bulletSpeed, ForceMode2D.Impulse);


    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(Collider.gameobject.tag = " player")
        {
            return;
        }
        if(colider.gameObject.tag = "Goombas")
    {
            Destroy(collider.gameObject);
        }
        Destroy(gameObject);
    }
}

