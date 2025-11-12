using UnityEngine;

public class RS_TestItemClassScript : MonoBehaviour
{
    ItemClass rock,  hat;
    RS_ConsumableItem potion, drink;
    RS_Weapon sword;


    RS_Inventory inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rock = new ItemClass("A Rock", 0, "This is one boring rock!!", 1.2f);
        sword = new RS_Weapon("Rapier", 1, "Sharp but flimsy!!", 0.8f, 35);
        potion = new RS_ConsumableItem("Green Potion", 2, " I really wouldn't!!", 0.2f,-50);
        hat = new ItemClass("Beret", 3, " A simple beret with a green logo", 0.1f);
        drink = new RS_ConsumableItem("Water", 4, 10);

        inventory = new RS_Inventory(20, 150f);




        if (inventory.AddRequest(potion)) print("Added " + potion.name);
        else
            print("Could not add");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (inventory.AddRequest(rock)) print("Added " + rock.name);
            else
                print("Could not add");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (inventory.AddRequest(potion)) print("Added " + potion.name);
            else
                print("Could not add");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (inventory.AddRequest(sword)) print("Added " + sword.name);
            else
                print("Could not add");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (inventory.AddRequest(hat)) print("Added " + hat.name);
            else
                print("Could not add");
        }


        if (Input.GetKeyDown(KeyCode.U))
        {
            int ind = 3;
            ItemClass item = inventory.RemoveRequest(ind);
            if (item != null)
                item.DisplayInfo();
        }

    }
}
