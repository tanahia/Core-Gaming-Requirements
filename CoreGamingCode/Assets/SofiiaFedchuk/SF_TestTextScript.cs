using System.Collections.Generic;
using UnityEngine;

public class SF_TestTextScript : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space)){
           Transform temp = Instantiate(textGOCloneTemplate);
           SF_TextControlScript myTempText = temp.GetComponent<SF_TextControlScript>();
           myTempText.Set_Text("Clone No. " + i.ToString());
            myTempText.SetFont();
           i++;
        }
    }
}
