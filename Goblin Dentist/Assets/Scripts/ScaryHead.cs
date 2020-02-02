using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryHead : Head
{
    protected override int badToothProbability => 50;

    public override HeadType headType => HeadType.Scary;

    protected override List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =>
        new List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector3(0.61f, -6.7f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerRight, 3),
            (new Vector3(-0.54f, -6.73f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerLeft, 3),
            (new Vector3(1.48f, -6.32f), new Vector3(0.41f, 0.41f), Tooth.ToothArea.LowerRight, 2),
            (new Vector3(-1.64f, -6.55f), new Vector3(0.41f, 0.38f), Tooth.ToothArea.LowerLeft, 2),
            (new Vector3(2.31f, -5.59f), new Vector3(0.38f, 0.3f), Tooth.ToothArea.LowerRight, 1),
            (new Vector3(-2.5f, -5.77f), new Vector3(0.38f, 0.3f), Tooth.ToothArea.LowerLeft, 1),

            (new Vector3(0.38f, -4.27f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.UpperRight, 3),
            (new Vector3(-0.68f, -4.31f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.UpperLeft, 3),
            (new Vector3(1.16f, -4.08f), new Vector3(0.41f, 0.39f), Tooth.ToothArea.UpperRight, 2),
            (new Vector3(-1.63f, -4.15f), new Vector3(0.41f, 0.39f), Tooth.ToothArea.UpperLeft, 2),
            (new Vector3(-2.47f, -3.71f), new Vector3(0.38f, 0.3f), Tooth.ToothArea.UpperRight, 1),
            (new Vector3(2f, -3.67f), new Vector3(0.38f, 0.3f), Tooth.ToothArea.UpperLeft, 1)
        };

    protected override void Start()
    {
        base.Start();
    }
}
