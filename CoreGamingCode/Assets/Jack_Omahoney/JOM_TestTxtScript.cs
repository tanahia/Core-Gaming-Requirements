using JetBrains.Annotations;
using UnityEngine;

public class JOM_TestTxtScript : MonoBehaviour
{
    int i = 0;
    JOM_txtcontrolscript myTextthingy;

    void Start()
    {
    

    }
    public Transform textGOCloneTemplate;


    //Creates specific positions where i want each clone to go on the screen
    public Vector3[] positions = new Vector3[]
  {
        new Vector3(),
        new Vector3(),
        new Vector3(),
        new Vector3()
  };
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            JOM_txtcontrolscript MyTempText = temp.GetComponent<JOM_txtcontrolscript>();
            MyTempText.SetText("Clone No " +  i.ToString());

            float screenWidth = Screen.width;
            float screenHeight = Screen.height;
            //sets the clones position to cycle throught preset positions

            temp.position = positions[i %positions.Length];

            i++;
         
         
        }
    }

}
