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
        Debug.Log("works");
        if(other.tag == "Player")
        {
            other.gameObject.SetActive(false);
            isPossesed = true;
        }
        
    }

    private void Update()
    {
        if (!isPossesed)
        {

        }
        else
        {
            rb.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), rb.velocity.y);
        }
    }


}
