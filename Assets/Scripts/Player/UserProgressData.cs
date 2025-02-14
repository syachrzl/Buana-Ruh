﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserProgressData {

    //Satuan Puzzle
    public bool AlreadyTaken;
    public bool AlreadyTaken2;
    public bool AlreadyTaken3;
    public bool AlreadyTaken4;
    public bool AlreadyTaken5;

    //Save Total Puzzle
    public float TotalPuzzle;
    
    //Player Position
    public float[] position;
    

    public UserProgressData(PlayerManager pm)
    {
        TotalPuzzle = pm.TotalPuzzle;
        AlreadyTaken = PuzzleCollectible.alreadyTaken;
        AlreadyTaken2 = PuzzleCollectible2.alreadyTaken2;
        AlreadyTaken3 = PuzzleCollectible3.alreadyTaken3;
        AlreadyTaken4 = PuzzleCollectible4.alreadyTaken4;
        AlreadyTaken5 = PuzzleCollectible5.alreadyTaken5;

        position = new float[3];
        position[0] = PlayerManager.lastCheckPointPos.x;
        position[1] = PlayerManager.lastCheckPointPos.y;
        position[2] = PlayerManager.lastCheckPointPos.z;
    }
    
}
