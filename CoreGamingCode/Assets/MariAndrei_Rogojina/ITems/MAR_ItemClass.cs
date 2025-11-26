

using UnityEngine;

public class MAR_ItemClass
{
    private string name;
    public int id;
    private string description;
    private float weight;
    private float defaultWeight = 1;

    public MAR_ItemClass(string newName, int newId, string newDescription, float newWeight)
    {

    }

    public MAR_ItemClass(string newName, int newId) {

        name = newName;
        id = newId;
        description = "Nothing to say here really";
        weight = defaultWeight;

    }
    public void displayInfo()
    {
        Debug.Log("Name: " +  name);
        Debug.Log("Description : " + description);
        Debug.Log("ID: " + id);
    }
}
