﻿using UnityEngine;
using Affdex;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerEmotions : AbstractAffdexListener
{
    //Text gamePausedText; 

    public override void onFaceFound(float timestamp, int faceId)
    {
        Debug.Log("Found the face");
    }

    public override void onFaceLost(float timestamp, int faceId)
    {
        Debug.Log("Lost the face: Pause Game!");
        Time.timeScale = 0;
     }

    public override void onImageResults(Dictionary<int, Face> faces)
    {
        Debug.Log("Got face result");
    }
}