using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Head : MonoBehaviour
{
    public enum HeadType
    {
        Pointy,
        Scary,
        Derpy
    }
    public GameObject tooth;

    public abstract HeadType headType { get; }

    protected abstract int badToothProbability { get; }

    protected abstract List<(Vector2 position, Vector2 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData { get; }

    protected virtual void Start()
    {
        foreach (var data in toothData)
        {
            GameObject newTooth = Instantiate(tooth);
            Tooth toothComp = newTooth.GetComponent<Tooth>();
            toothComp.Init(data.position, data.scale, data.toothArea, data.layerOrder, badToothProbability);
        }
    }
}
