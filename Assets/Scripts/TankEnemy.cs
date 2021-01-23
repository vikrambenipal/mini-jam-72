﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : Enemy
{
    // Update is called once per frame
    void Update()
    {
        if (!isPossesed)
        {
            // ai movement 
        }
        else
        {
            // player input 
            rb.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), moveSpeed * Input.GetAxisRaw("Vertical"));
        }
    }
}
