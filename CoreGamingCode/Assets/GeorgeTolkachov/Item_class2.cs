using UnityEngine;

public class Item_class2
{
    private string name;
    public int id;
    private string description;
    private float weight;
    private float defaultWeight = 1;

    public Item_class2(string newName, int newId, string newDescription, float newWeight) 
    {
        name = newName;
        id = newId;
        description = newDescription;
        weight = newWeight;

    }

    public Item_class2(string newName, int newId)
    {
        name = newName;
        id = newId;
        description = "Nothing to say";
        weight = defaultWeight;
    }
    public void DisplayInfo() 
    {
        Debug.Log("Name: " + name);
        Debug.Log("Weight: " + weight);
        Debug.Log("Id: " + id);
    }
}
