using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rBody;
    private  AudioSource source;
    private float enemyDirection = 1;
    private BoxCollider2D boxCollider;
   
    public float enemySpeed = 2;
    public Animator anim;
    public AudioClip deathSound;
  
    // Start is called before the first frame update
    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rBody.velocity = new Vector2(enemyDirection * enemySpeed, rBody.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3 ||collision.gameObject.tag == "Goombas")
        {
         if(enemyDirection == 1)
        {
            enemyDirection = -1;
        }
        else if(enemyDirection == -1)
        {
            enemyDirection = 1;
        }
        }
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

    public void GoombaDeath()
    {
        source.PlayOneShot(deathSound);
        boxCollider.enabled = false;
        rBody.gravityScale = 0;
        enemyDirection = 0;
        Destroy(gameObject, 0.5f);
    }
}