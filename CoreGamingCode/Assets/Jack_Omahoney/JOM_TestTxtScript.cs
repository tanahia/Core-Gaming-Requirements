using JetBrains.Annotations;
using UnityEngine;

public class JOM_TestTxtScript : MonoBehaviour
{
    int i = 0;
    int clonecycle = 0;
    JOM_txtcontrolscript myTextthingy;


    public Transform textGOCloneTemplate;

    //Creates specific positions where i want each clone to go on the screen
    public Vector3[] positions = new Vector3[]
  {
        new Vector3(-15,5,0),
        new Vector3(15,5,0),
        new Vector3(15,-14,0),
        new Vector3(-15,-14,0)
  };
    void Start()
    {
    


    }
 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            //gets the rect transform of the clone
            RectTransform tempRectTransform = temp.GetComponent<RectTransform>();

            JOM_txtcontrolscript MyTempText = temp.GetComponent<JOM_txtcontrolscript>();
            MyTempText.SetText("Clone No " +  i.ToString());

            Vector3 targetposition = positions[clonecycle];

            tempRectTransform.position = new Vector3 (15,5,0);
            
            i++;

            clonecycle = (clonecycle + 1) % positions.Length;
         
         
        }
    }

}
