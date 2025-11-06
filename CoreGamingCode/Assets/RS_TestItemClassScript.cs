using UnityEngine;

public class RS_TestItemClassScript : MonoBehaviour
{
    ItemClass rock,  hat;
    RS_ConsumableItem potion, drink;
    RS_Weapon sword;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rock = new ItemClass("A Rock", 0, "This is one boring rock!!", 1.2f);
        sword = new RS_Weapon("Rapier", 1, "Sharp but flimsy!!", 0.8f, 35);
        potion = new RS_ConsumableItem("Green Potion", 2, " I really wouldn't!!", 0.2f,-50);
        hat = new ItemClass("Beret", 3, " A simple beret with a green logo", 0.1f);
        drink = new RS_ConsumableItem("Water", 4, 10);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) { potion.DisplayInfo(); }
        if (Input.GetKeyDown(KeyCode.C)) { potion.Consume(); }
        if (Input.GetKeyDown(KeyCode.S)) { sword.Attack(); }
    }
}
