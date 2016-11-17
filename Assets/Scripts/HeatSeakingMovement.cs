﻿using UnityEngine;
using System.Collections;

public class HeatSeakingMovement : MonoBehaviour
{
    public Transform target;

    // Use this for initialization
    void Start()
    {
        if (target == null)
        {
            target = FindObjectOfType<Player>().transform;        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, target.position, Time.deltaTime);
    }
}
