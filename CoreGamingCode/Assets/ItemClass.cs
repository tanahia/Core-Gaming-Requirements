using UnityEngine;

public class ItemClass 
{
    public string name;
    public int id;
    private string description;
    internal float weight;
    private float defaultWeight = 1;

    public ItemClass(string newName, int newId, string newDescription, float newWeight)
    {
        name = newName;
        id = newId;
        description = newDescription;
        weight = newWeight;

    }

    public ItemClass(string newName,int newId)
    {
        name = newName;
        id = newId;
        description = "Nothing to say here really!!";
        weight = defaultWeight;

    }

    public virtual void DisplayInfo()
    {
        Debug.Log("Name : " + name);
        Debug.Log("Desc : " + description);
        Debug.Log("Weight : " +  weight);
    }
}
