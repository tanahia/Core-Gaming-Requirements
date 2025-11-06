using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class RS_Weapon : ItemClass
{
    int damage;

    public RS_Weapon(string newName, int newId, int newDamage) : base(newName, newId)
    {
        damage = newDamage;
    }

    public RS_Weapon(string newName, int newId, string newDescription, float newWeight, int newDamage) : base(newName, newId, newDescription, newWeight)
    {
        damage = newDamage;
    }

    public void Attack()
    {
        Debug.Log("You attack with the " + name + " and do " + damage + " damage");
    }
}
