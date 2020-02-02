using System;
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
            (new Vector3(0.61f, -6.26f),   new Vector3(1.285f, 1.683f), Tooth.ToothArea.Lower, 3),
            (new Vector3(-0.66f, -6.67f), new Vector3(1.419f, 1.37f), Tooth.ToothArea.Lower, 3),
            (new Vector3(1.84f, -5.23f),  new Vector3(1.365f, 1.327f), Tooth.ToothArea.Lower, 2),
            (new Vector3(-1.81f, -6.15f), new Vector3(1.586f, 1.552f), Tooth.ToothArea.Lower, 2),
            (new Vector3(2.48f, -3.98f),  new Vector3(1.545f, 1.409f), Tooth.ToothArea.Lower, 1),
            (new Vector3(-2.7f, -4.86f),  new Vector3(1.225f, 1.243f), Tooth.ToothArea.Lower, 1),

            (new Vector3(0.39f, -3.87f),  new Vector3(2.103f, 1.583f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-1.22f, -3.5f), new Vector3(1.998f, 1.49f), Tooth.ToothArea.Upper, 3),
            (new Vector3(1.69f, -3.36f),  new Vector3(1.601f, 1.431f), Tooth.ToothArea.Upper, 2),
            (new Vector3(-2.66f, -3.2f), new Vector3(1.496f, 1.366f), Tooth.ToothArea.Upper, 2),
            (new Vector3(-3.8f, -2.82f), new Vector3(1.389f, 1.344f), Tooth.ToothArea.Upper, 1),
            (new Vector3(3.2f, -2.49f),   new Vector3(1.721f, 1.251f), Tooth.ToothArea.Upper, 1)
        };

    protected override void Start()
    {
        base.Start();
    }
}
