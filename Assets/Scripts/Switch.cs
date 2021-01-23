using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            animator.Play("Switch");
            Debug.Log("switch triggered");
        }
    }
}
