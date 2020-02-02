using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryHead : Head
{
    int _badToothProbability;

    public override HeadType headType => HeadType.Scary;
    public override string SpriteLocation => "Assets/ArtAssets/Gobtest/goblin face test 2.png";

    private List<(Vector2 position, Vector2 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =
        new List<(Vector2 position, Vector2 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector2(0.53f, -6.25f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerRight, 3),
            (new Vector2(1.62f, -6.13f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerLeft, 3),
            (new Vector2(2.44f, -5.79f), new Vector3(0.41f, 0.41f), Tooth.ToothArea.LowerRight, 2),
            (new Vector2(-0.51f, -5.98f), new Vector3(0.41f, 0.41f), Tooth.ToothArea.LowerLeft, 2),
            (new Vector2(-1.18f, -4.99f), new Vector3(0.38f, 0.38f), Tooth.ToothArea.LowerRight, 1),
            (new Vector2(3.18f, -4.78f), new Vector3(0.38f, 0.38f), Tooth.ToothArea.LowerRight, 1)
        };

    public override void Init(int badToothProbability)
    {
        _badToothProbability = badToothProbability;
        foreach (var data in toothData)
        {
            GameObject newTooth = new GameObject($"tooth.{Enum.GetName(typeof(Tooth.ToothArea),data.toothArea)}.{data.layerOrder}");
            newTooth.AddComponent<Tooth>();
            break;
            //newTooth
            //Tooth tooth = Instantiate(Tooth, data.position, null, this);
            //tooth.Init(data.position, data.scale, data.toothArea, data.layerOrder, _badToothProbability);
        }
    }

    private void Start()
    {
        _badToothProbability = 50;
        foreach (var data in toothData)
        {
            GameObject newTooth = Instantiate(tooth);
            Tooth toothComp = newTooth.GetComponent<Tooth>();
            toothComp.Init(data.position, data.scale, data.toothArea, data.layerOrder, _badToothProbability);
        }
    }

    private void Update()
    {
        
    }



    //protected override List<Tooth> SetupTeeth()
    //{
    //    return new List<Tooth>
    //    {
    //        new Tooth(new Vector2(0.53f, -6.25f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerRight, 3, _badToothProbability),
    //        new Tooth(new Vector2(1.62f, -6.13f), new Vector3(0.45f, 0.45f), Tooth.ToothArea.LowerLeft, 3, _badToothProbability),
    //        new Tooth(new Vector2(2.44f, -5.79f), new Vector3(0.41f, 0.41f), Tooth.ToothArea.LowerRight, 2, _badToothProbability),
    //        new Tooth(new Vector2(-0.51f, -5.98f), new Vector3(0.41f, 0.41f), Tooth.ToothArea.LowerLeft, 2, _badToothProbability),
    //        new Tooth(new Vector2(-1.18f, -4.99f), new Vector3(0.38f, 0.38f), Tooth.ToothArea.LowerRight, 1, _badToothProbability),
    //        new Tooth(new Vector2(3.18f, -4.78f), new Vector3(0.38f, 0.38f), Tooth.ToothArea.LowerRight, 1, _badToothProbability)
    //    };
    //}
}
