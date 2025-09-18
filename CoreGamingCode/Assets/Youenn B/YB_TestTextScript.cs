using UnityEngine;

public class YB_TestTextScript : MonoBehaviour
{
    int i = 0;
    YB_TextControlScript textThingy;

    public Transform textGOCloneTemplate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            YB_TextControlScript myTempText = temp.GetComponent<YB_TextControlScript>();
            myTempText.SetText("clone No." + i.ToString());
            i++;
        }
    }
}
