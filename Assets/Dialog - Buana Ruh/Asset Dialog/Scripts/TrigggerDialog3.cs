﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigggerDialog3 : MonoBehaviour
{
    [SerializeField] private GameObject dialog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            dialog.SetActive(true);
        }
    }
}
