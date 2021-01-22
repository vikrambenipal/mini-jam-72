using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float ghostSpeed = 10f;
    public float jumpSpeed = 5f;

    public bool isGrounded;

    public Rigidbody2D rb;
    public BoxCollider2D boxCollider;
    public bool isDead;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            this.tag = "PlayerGhost";
            rb.velocity = new Vector2(ghostSpeed * Input.GetAxisRaw("Horizontal"), ghostSpeed * Input.GetAxisRaw("Vertical"));
            rb.gravityScale = 0;
            boxCollider.enabled = false;
        }
        else
        {
            this.tag = "Player";
            rb.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), rb.velocity.y);
            rb.gravityScale = 1;
            boxCollider.enabled = true;

            // Jump
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.up * jumpSpeed;
            }
        }
    }
}
