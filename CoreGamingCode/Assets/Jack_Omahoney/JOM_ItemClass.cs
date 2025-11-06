using UnityEngine;
public class JOM_ItemClass
{
    private float defaultWeight = 1;
    private string name;
    public int id;
    private string description;
    private float weight;

    public JOM_ItemClass(string newName, int newId, string newDescription, float newWeight)
    {
        name = newName;
        id = newId;
        description = newDescription;
        weight = newWeight;

    }

    public JOM_ItemClass(string newName, int newId)
    {
        name = newName;
        id = newId;
        description = "No description available.";
        weight = defaultWeight;
    }

    public virtual void DisplayInfo()
    {
        Debug.Log("Item Name: " + name + "\nID: " + id + "\nDescription: " + description + "\nWeight: " + weight + "kg");
    }
}
