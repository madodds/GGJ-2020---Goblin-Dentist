using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Head : MonoBehaviour
{
    public enum HeadType
    {
        Pointy,
        Scary
    }

    public List<Tooth> teeth;

    public abstract string SpriteLocation { get; }

    public abstract HeadType headType { get; }

    public abstract void Init(int badToothProbability);

    public GameObject tooth;
}
