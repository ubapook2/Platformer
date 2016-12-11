﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if(player != null)
        {
            player.takeDamage();
        }
    }
}
