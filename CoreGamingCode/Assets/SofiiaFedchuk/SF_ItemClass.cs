using UnityEngine;

public class SF_ItemClass
{
    public string name;
    public  int id;
    private string description;
    private float weight;
    private float defaultWeight=1;
    public SF_ItemClass(string newName, int newId, string newDescription, float newWeight)
    {

        name = newName;
        id = newId;
        description = newDescription;
        weight = newWeight;
    }
    public SF_ItemClass(string newName, int newId)
    {
        name= newName;
        id = newId;
        description = "Nothing to say really...";
        weight = defaultWeight;
    }
    public virtual void DisplayInfo()
    {
        Debug.Log("Name:" + name);
        Debug.Log("Description:" + description);
        Debug.Log("Weight:" + weight);

    }
}
