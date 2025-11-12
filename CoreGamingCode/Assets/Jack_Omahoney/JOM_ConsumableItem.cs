using Unity.VisualScripting;
using UnityEngine;

public class JOM_ConsumableItem : JOM_ItemClass
{
    int healthBoost;
    public JOM_ConsumableItem(string newName, int newId, int newHealthBoost) : base(newName, newId)
    {
        healthBoost = newHealthBoost;
    }

    public JOM_ConsumableItem(string newName, int newId, string newDescription, float newWeight, int newHealthBoost) : base(newName, newId, newDescription, newWeight)
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
        Debug.Log("You have consumed and gained " + healthBoost + " health.");
    }


}

