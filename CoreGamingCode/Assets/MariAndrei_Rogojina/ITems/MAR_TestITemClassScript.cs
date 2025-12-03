using UnityEngine;

public class MAR_TestITemClassScript : MonoBehaviour
{
    MAR_ItemClass rock, sword, potion, hat, drink;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rock = new MAR_ItemClass("rock", 0, "A rock", 1.2f);
        sword = new MAR_ItemClass("sword", 1, "A heavy sword", 2f);
        potion = new MAR_ItemClass("healing potion", 2, "A healing potion", 0.5f);
        hat = new MAR_ItemClass("hat", 3, "A head accessory", 0.3f);
        drink = new MAR_ItemClass("Water", 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R)) {
            
        }

    }
}
