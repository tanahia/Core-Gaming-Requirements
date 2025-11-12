using UnityEngine;

public class HS_Weapon : HS_ItemClass
{
    int damage;

    public HS_Weapon(string newName, int newId, int newDamage) : base(newName, newId)
    {
        damage = newDamage;
    }

    public HS_Weapon(string newName, int newId, string newDescription, float newWeight, int newDamage) : base(newName, newId, newDescription, newWeight)
    {
        damage = newDamage;
    }

    public void Attack()
    {
        Debug.Log("You attack with the " + name + " and do " + damage + " damage");
    }
}
