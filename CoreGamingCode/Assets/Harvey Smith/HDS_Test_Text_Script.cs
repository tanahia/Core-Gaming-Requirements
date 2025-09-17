using UnityEngine;

public class HDS_Test_Text_Script : MonoBehaviour
{
    int i = 0;
    TextControlScriot mytext;

    public Transform textGOCloneTemplate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //mytext = FindFirstObjectByType<TextControlScriot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);  
            TextControlScriot myTempText = temp.GetComponent<TextControlScriot>();
            myTempText.SetText("Clone No. " + i.ToString());
            i++;
        }
        //mytext.SetText("Score " + i.ToString());
        //i++;
    }
}
