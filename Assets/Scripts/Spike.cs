using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public PlayerController pc;

    private void Awake()
    {
        pc = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" || LayerMask.LayerToName(other.gameObject.layer) == "EnemyCapture")
        {
            pc.isDead = true;

            if(LayerMask.LayerToName(other.gameObject.layer) == "EnemyCapture")
            {
                pc.gameObject.SetActive(true);
                pc.transform.position = other.transform.position;
                other.gameObject.SetActive(false);
            }
        }
    }
}
