using UnityEngine;

public class RS_Test_Text_Script : MonoBehaviour
{
    Transform temp;
    int i = 0;
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
           Transform temp =  Instantiate(textGOCloneTemplate);
            RS_TextControlScript myTempText = temp.GetComponent<RS_TextControlScript>();
            myTempText.SetText("Clone No. " + i.ToString());
            i++;
        }
        
   
    }
}
