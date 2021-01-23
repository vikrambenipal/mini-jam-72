using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public void KillPlayer()
    {
        FindObjectOfType<PlayerController>().isDead = true;
    }
}
