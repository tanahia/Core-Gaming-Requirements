using UnityEngine;

public class MS_Test_Text : MonoBehaviour
{
    int i = 0;
    // MS_TextControl textControl;

    public Transform textGOCloneTemplate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // textControl = FindFirstObjectByType<MS_TextControl>();
    }

    // Update is called once per frame
    void Update()
    {
        // textControl.SetText("Who lives in the bottom of ocean? Spange Bob Square Pants :)"); - first text displaying

        // textControl.SetText("Score " + i.ToString()); - text modifying
        // i++;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            MS_TextControl textControl = temp.GetComponent<MS_TextControl>();
            textControl.SetText("Clone No. " + i.ToString());
            i++;
        }
    }
}
