using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HS_Test_ColourScript : MonoBehaviour
{
    private int i;
    public Transform textGOCloneTemplate;

    private List<MS_TextControl> allTexts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        allTexts = new List<MS_TextControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            MS_TextControl myTempText = temp.GetComponent<MS_TextControl>();
            allTexts.Add(myTempText);
            myTempText.SetText("Clone No. " + i.ToString());
            myTempText.SetColor(new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
            
            TextControlScriot myTempText1 = temp.GetComponent<TextControlScriot>();
            myTempText1.SetFontSize(Random.Range(1f, 19f));
            
            i++;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            allTexts[Random.Range(0, allTexts.Count)].SetColor(Color.black);
        }
    }
}
