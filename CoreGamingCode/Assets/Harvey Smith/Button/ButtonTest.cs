using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    public Transform buttonCloneTemplate;
    public Transform canvas;
    ButtonControlScript myButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform buttonT = Instantiate(buttonCloneTemplate,canvas);
        myButton = buttonT.GetComponent<ButtonControlScript>();
        myButton.SetColors(Color.red, Color.beige, Color.yellow, Color.green);
        myButton.Initilise();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
