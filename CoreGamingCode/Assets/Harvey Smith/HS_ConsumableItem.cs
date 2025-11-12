using UnityEngine;

public class HS_ConsumableItem : HS_ItemClass
{
    int healthBoost;
    public HS_ConsumableItem(string newName, int newId, int newHealthBoost) : base(newName, newId)
    {
        healthBoost = newHealthBoost;
    }

    public HS_ConsumableItem(string newName, int newId, string newDescription, float newWeight, int newHealthBoost) : base(newName, newId, newDescription, newWeight)
    {
        healthBoost = newHealthBoost;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Debug.Log("Health Boost :" + healthBoost);
    }
    public void Consume()
    {
        Debug.Log("You consume the " + name + " you recieve a health boost of " + healthBoost);
    }
}
