using UnityEngine;

public class JOM_WeaponClass : JOM_ItemClass
{
    int damage;

    public JOM_WeaponClass(string newName, int newId, int newDamage) : base(newName, newId)
    {
        damage = newDamage;
    }

    public JOM_WeaponClass(string newName, int newId, string newDescription, float newWeight, int newDamage) : base(newName, newId, newDescription, newWeight)
    {
        damage = newDamage;
    }

    public void Attack()
    {
        Debug.Log("You attack with the " + name + " and do " + damage + " damage");
    }
}
