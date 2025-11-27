using UnityEngine;

public class MAR_InventoryTest : MonoBehaviour
{
    private RS_Inventory inv;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inv = new RS_Inventory(30, 200);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
