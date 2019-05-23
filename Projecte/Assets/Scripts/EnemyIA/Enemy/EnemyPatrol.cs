﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : EnemyState
{
    private Vector2 dirPoint;

    private void Start()
    {
        newPoint();
    }

    private void Update()
    {
        if(Vector2.Distance((Vector2)this.transform.position,dirPoint) <= 0.5f)
        {
            atorSke.SetBool("Walking", false);
            newPoint();
        }
    }

    private void FixedUpdate()
    {   
        
        this.transform.position = Vector2.MoveTowards(this.transform.position, dirPoint, enemy._speed);      

    }

    private void newPoint()
    {
        dirPoint = Random.insideUnitCircle * 5f + (Vector2)this.transform.position;
        print(dirPoint);
        //atorSke.SetBool("Walking", true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.GetComponent<EnemyChase>().enabled = true;
            this.enabled = false;
        }
    }
}
    