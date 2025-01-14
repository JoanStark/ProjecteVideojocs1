﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("breakable"))
        { 
            other.GetComponent<objectDestroyer>().Smash();
        }

        if (other.CompareTag("Enemy"))
        {
            if(other.isTrigger == false)
            {
                other.GetComponent<CharacterState>().recieveDmg(GameManager.instance.swordDmg);
            }
        }
    }
}
