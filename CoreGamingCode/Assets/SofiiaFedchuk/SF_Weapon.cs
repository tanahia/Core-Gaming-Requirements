using UnityEngine;

public class SF_Weapon : SF_ItemClass
{
    int damage;
    public SF_Weapon(string newName, int newId, string newDescription, float newWeight, int newDamage) : base(newName, newId, newDescription, newWeight)
    {
        damage = newDamage;
    }
    public SF_Weapon(string newName, int newId, int newDamage) :base(newName, newId) {
        damage = newDamage;
    }
    public void Attack()
    {
        Debug.Log("You attacked with " + name + ". And did " + damage+" damage");
    }
}
