using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baboinga : MonoBehaviour
{
    public int increase = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            PlayerMovementButNotJohn playerScript = player.GetComponent<PlayerMovementButNotJohn>();

            if (playerScript)
            {
                playerScript.extraJumpValue += increase;
                Destroy((gameObject));
            }
        }
    }
}
