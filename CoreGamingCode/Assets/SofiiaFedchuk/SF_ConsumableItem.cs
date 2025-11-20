using UnityEngine;

public class SF_ConsumableItem : SF_ItemClass
{
    int healthBoost;
    public SF_ConsumableItem(string newName, int newId, string newDescription, float newWeight, int newHealthBoost) : base(newName, newId, newDescription, newWeight)
    {
        healthBoost=newHealthBoost;
    }
    public SF_ConsumableItem(string newName, int newId, int newHealthBoost) : base(newName, newId)
    {
        healthBoost = newHealthBoost;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Debug.Log("Health Boost: " + healthBoost);
    }
    public void Consume()
    {
        Debug.Log("You consumed the " + name+". You received health boost of "+healthBoost);
    }
    }
