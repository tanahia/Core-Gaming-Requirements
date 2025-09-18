using UnityEngine;

public class GT_Test_Text_Script : MonoBehaviour
{
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
            Transform temp = Instantiate(textGOCloneTemplate);      
            GT_TextControlScript myTempText = temp.GetComponent<GT_TextControlScript>();
            myTempText.SetText("Clone No. " + i.ToString());
            i++;
        }



    }
}
