using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tooth : MonoBehaviour
{

    public enum ToothType
    {
        Healthy,
        Wooden,
        Gold,
        Metal
    }
    
    enum ToothAttribute
    {
        Healthy,
        Rotten
    }

    public enum ToothArea
    {
        UpperLeft,
        UpperRight,
        LowerLeft,
        LowerRight
    }

    private List<(ToothType type, ToothAttribute attribute, string spritePath)> toothData 
        = new List<(ToothType type, ToothAttribute attribute, string spritePath)>
    {
        (ToothType.Healthy, ToothAttribute.Healthy, "ArtAssets/Teeth/{0}/gobtooth_n"),
        (ToothType.Wooden, ToothAttribute.Rotten, "ArtAssets/Teeth/{0}/gobtooth_w"),
        (ToothType.Gold, ToothAttribute.Rotten, "ArtAssets/Teeth/{0}/gobtooth_g"),
        (ToothType.Metal, ToothAttribute.Rotten, "ArtAssets/Teeth/{0}/gobtooth_m")
    };

    private (ToothType type, ToothAttribute attribute, string spritePath) toothSelection;
    
    public void Init(Vector2 position, Vector2 scale, ToothArea toothArea, int layerOrder, int badToothProbability)
    {
        // Determine if the tooth should be healthy.
        ToothAttribute preferredAttribute = UnityEngine.Random.Range(1, 100) >= 
            badToothProbability ? ToothAttribute.Rotten : ToothAttribute.Healthy;

        // Randomly select a tooth of the healthiness determined.
        var possibleTeeth = toothData.Where(t => t.attribute == preferredAttribute);
        toothSelection = possibleTeeth.ElementAt(UnityEngine.Random.Range(0, possibleTeeth.Count()));

        // Set the tooth sprite path based on the area it exists. Requires the folder structure to be setup correctly.
        toothSelection.spritePath = string.Format(toothSelection.spritePath, Enum.GetName(typeof(ToothArea), toothArea));

        // Setup the location and sprite
        SpriteRenderer toothSprite = GetComponent<SpriteRenderer>();
        toothSprite.transform.position = position;
        toothSprite.transform.localScale = scale;
        toothSprite.sprite = Resources.Load(toothSelection.spritePath, typeof(Sprite)) as Sprite;
        toothSprite.sortingOrder = layerOrder;
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
