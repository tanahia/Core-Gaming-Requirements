using UnityEngine;

public class MAR_Test_Text : MonoBehaviour
{
    int i = 0;
    // MS_TextControl textControl;

    public Transform textGOCloneTemplate;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // textControl = FindFirstObjectByType<MAR_TextControl>();
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiates a text on the screen, Changing the number of it each time.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            MAR_TextControl textControl = temp.GetComponent<MAR_TextControl>();
            textControl.SetText("Clone No. " + i.ToString());
            i++;
        }
    }
}
