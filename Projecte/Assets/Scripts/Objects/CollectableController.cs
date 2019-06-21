﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{

    public AudioClip PickUpSound;
    public AudioSource PotionAudioSource;

    public Item item;
    public int quantity = 1;

    // Use this for initialization
    void Start()
    {
        PotionAudioSource.clip = PickUpSound;
        GetComponent<SpriteRenderer>().sprite = item.displayImage;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            PotionAudioSource.Play();
            GameManager.instance.getPlayerInv().Add(item, quantity);
            Destroy(gameObject,0.1f);
        }
    }

    private void OnDrawGizmos()
    {
        GetComponent<SpriteRenderer>().sprite = item.displayImage;
    }
}

