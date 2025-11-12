using UnityEngine;

public class SF_TestItemClassScript : MonoBehaviour
{
    SF_ItemClass rock, hat;
    SF_Weapon sword;
    SF_ConsumableItem potion, drink;
    void Start()
    {
        rock = new SF_ItemClass("A Rock", 0, "This is one boring rock!", 1.2f);
        sword = new SF_Weapon("Rapier", 1, "Sharp but flimsy!", 0.8f, 50);
        potion = new SF_ConsumableItem("Green Potion", 2, "Healing potion", 0.2f, 50);
        hat = new SF_ItemClass("Beret", 3, "A simple but elegant beret", 0.1f);
        drink = new SF_ConsumableItem("Water", 4, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            rock.DisplayInfo();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sword.DisplayInfo();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            potion.DisplayInfo();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            hat.DisplayInfo();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           drink.DisplayInfo();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            potion.Consume();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            sword.Attack();
        }

    }
}
