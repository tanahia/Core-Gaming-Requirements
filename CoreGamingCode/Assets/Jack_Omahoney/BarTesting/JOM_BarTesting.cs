using UnityEngine;

public class JOM_BarTesting : MonoBehaviour
{
    public Transform barClone;
    private HS_BarControl mana;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform Mana = Instantiate(barClone);
        mana = Mana.GetComponentInChildren<HS_BarControl>();

        mana.SetBarPosition(new Vector2(-150, -200));
        mana.BarColour(Color.cyan);
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            mana.IncrementBar(10);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            mana.ReduceBar(10);
        }
        
     

    }

    // Update is called once per frame
    void Update()
    {
        mana.BarColourChange(80, 40, Color.cyan, Color.lightBlue, Color.darkRed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mana.SetBarValue(1);
        }
 
        if (Input.GetKeyDown(KeyCode.R))
        {
            mana.SetBarValue(90);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            mana.SetBarPosition(new Vector2(0, 30));
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            mana.SetBarPosition(new Vector2(0, -30));
        }
    }
}
