﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerpyHead : Head
{
    protected override int badToothProbability => 40;

    public override HeadType headType => HeadType.Derpy;

    protected override List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =>
        new List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector3(0.53f, -6.25f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerRight, 3),
            (new Vector3(1.62f, -6.13f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerLeft, 3),
            (new Vector3(2.44f, -5.79f), new Vector3(0.41f, 0.41f), Tooth.ToothArea.LowerRight, 2),
            (new Vector3(-0.51f, -5.98f), new Vector3(0.41f, 0.41f), Tooth.ToothArea.LowerLeft, 2),
            (new Vector3(-1.18f, -4.99f), new Vector3(0.38f, 0.38f), Tooth.ToothArea.LowerRight, 1),
            (new Vector3(3.18f, -4.78f), new Vector3(0.38f, 0.38f), Tooth.ToothArea.LowerRight, 1)
        };

    protected override void Start()
    {
        base.Start();
    }
}
