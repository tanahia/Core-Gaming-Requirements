using UnityEngine;

public class HDS_Test_Text_Script : MonoBehaviour
{
    int i = 0;
    TextControlScriot mytext;

    public Transform textGOCloneTemplate;
   
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
            float randomSize = Random.Range(1f, 200f);
            myTempText.SetFontSize(randomSize);
            i++;
        }
       
    }
}
