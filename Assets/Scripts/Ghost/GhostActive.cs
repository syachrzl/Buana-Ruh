﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostActive : MonoBehaviour
{
    public GameObject hantu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            hantu.SetActive(true);
        }
    }
}
