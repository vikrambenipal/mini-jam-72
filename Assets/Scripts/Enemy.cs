using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isAlive;
    public bool isPossesed;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    private void Start()
    {
        isAlive = true;
        isPossesed = false;
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerGhost")
        {
            other.gameObject.SetActive(false);
            isPossesed = true;
        }
        
    }

    private void Update()
    {
        if (!isPossesed)
        {
            // ai movement 
        }
        else
        {
            // player input 
            rb.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), rb.velocity.y);
        }
    }


}
