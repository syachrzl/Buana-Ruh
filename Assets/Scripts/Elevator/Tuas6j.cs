﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tuas6j : MonoBehaviour
{
    // untuk tampilan instruksi di layar 
    public TextMeshProUGUI instructionText;
    public GameObject instrukObject;

    public PlayerTuas pt;
    public Platform6j plat;

    public bool statusPlat = false;

    //Kode Unik
    public bool kodePlat4 = false;

    //Animasi
    private Animator anim;

    private void Update()
    {
        if (pt.statusTuasUp == true)
        {
            statusPlat = true;
        }
        else if (pt.statusTuasDown == true)
        {
            statusPlat = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            instrukObject.SetActive(true);
            instructionText.text = "Press E";
            kodePlat4 = true;
            statusPlat = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            instrukObject.SetActive(false);
            statusPlat = false;

        }
    }
}
