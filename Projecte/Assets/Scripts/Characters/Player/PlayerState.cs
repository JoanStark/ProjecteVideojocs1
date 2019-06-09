﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlayerStates
{
    attack, walk, idle, flash
}


[RequireComponent(typeof(AudioSource))]
public class PlayerState : CharacterState {

    protected SpriteRenderer sprPlayer, sprShadow;
    protected Rigidbody2D rb2D;
    protected Animator animator;

    protected float featherPower;

    protected float h, v;

    protected PlayerStates currentState;

    protected PlayerModel playerModel;

    public float getHealth()
    {
        return this.health;
    }
    protected AudioSource source;

    public override void InitState()
    {
        playerModel = GameManager.instance.playerModel;
        rb2D = GetComponent<Rigidbody2D>();
        sprPlayer = GetComponent<SpriteRenderer>();
        sprShadow = transform.Find("Shadow").gameObject.GetComponent<SpriteRenderer>();

        animator = GetComponent<Animator>();

        source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        
    }

    public void getDmg(float damageRecieved)
    {
        
        GameManager.instance.playerGetDmg(damageRecieved);
        GetComponentsInChildren<Image>()[2].fillAmount = GameManager.instance.getplayerHealth() / playerModel.health;
    }
}