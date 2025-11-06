using UnityEngine;

public class JOM_TestItemClassScript : MonoBehaviour
{
    JOM_ItemClass rock,hat;
    JOM_ConsumableItem potion, drink;
    JOM_WeaponClass sword;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rock = new JOM_ItemClass("A Rock",0,"This is one boring rock",1.2f);
        sword = new JOM_WeaponClass("A Sword",1,"This is a sharp sword",3.5f,35);
        potion = new JOM_ConsumableItem("A Health Potion",2,"This potion restores health",0.5f,-50);
        hat = new JOM_ItemClass("A Wizard Hat",3,"This hat makes you look like a wizard",0.8f);
        drink = new JOM_ConsumableItem("Water", 4,+10);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            rock.DisplayInfo();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            sword.Attack();
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            potion.DisplayInfo();
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            hat.DisplayInfo();
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            drink.DisplayInfo();
        }

    }
}
