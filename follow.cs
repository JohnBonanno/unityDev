﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public float movementSpeed = 10;

    void Update()
    {

        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

    }
}