using Unity.VisualScripting;
using UnityEngine;

public class HS_TestItemClassScript : MonoBehaviour
{
    HS_ItemClass hat, rock;
    HS_ConsumableItem potion, drink;
    HS_Weapon sword;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rock = new HS_ItemClass("Rock", 0, "This is one boring rock...", 1.2f);
        sword = new HS_Weapon("Rapier", 1, "Sharp but flimsy!", 0.8f, 50);
        potion = new HS_ConsumableItem("Green Potion", 2, "I really wouldnt!!", 0.2f, -50);
        hat = new HS_ItemClass("Beret", 3, "A simple beret with a green logo", 0.1f);
        drink = new HS_ConsumableItem("Water", 4, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            potion.DisplayInfo();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            potion.Consume();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sword.Attack();
        }



    }
}
