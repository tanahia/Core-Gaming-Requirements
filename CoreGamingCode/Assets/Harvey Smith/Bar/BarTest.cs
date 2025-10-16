using UnityEngine;

public class BarTest : MonoBehaviour
{
    public Transform barClone;
    private HS_BarControl health, stamina;
    
    void Start()
    {
        Transform Health = Instantiate(barClone);
       Transform Stamina = Instantiate(barClone);
        health = Health.GetComponentInChildren<HS_BarControl>();
       stamina = Stamina.GetComponentInChildren<HS_BarControl>();
        
        health.SetBarPosition(new Vector2(-200, -200));
        stamina.SetBarPosition(new Vector2(200, -200));
        health.BarColourChange(90, 50, Color.green, Color.yellow, Color.red);
       stamina.BarColour(Color.blue);
        if (Input.GetKeyDown(KeyCode.A))
        {
            health.ReduceBar(10);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            health.IncrementBar(10);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            stamina.ReduceBar(10);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            stamina.IncrementBar(10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
