using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class JOM_TestTxtScript : MonoBehaviour
{
    int i = 0;
    int clonecycle = 0;
    JOM_txtcontrolscript myTextthingy;

    //This creates is a list of Vector3 positions that the text will be moved to
    List<Vector3> positions;

    public Transform textGOCloneTemplate;


    void Start()
    {
        //This code uses positions.add to add positions you define to a list
        positions = new List<Vector3>();
        positions.Add(new Vector3(-15, 5, 0));
        positions.Add(new Vector3(15, 5, 0));
        positions.Add(new Vector3(15, -14, 0));
        positions.Add(new Vector3(-15, -14, 0));

    }
 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            
            

            JOM_txtcontrolscript MyTempText = temp.GetComponent<JOM_txtcontrolscript>();
            MyTempText.SetText("Clone No " +  i.ToString());

            //This sets the position of the text using the list of positions defined in start
            MyTempText.SetPosition(positions[clonecycle]);
           
            //adds 1 to the clone no counter
            i++;

            //Here +1 is added to the clonecycle to move on to the next position in the list
            clonecycle = (clonecycle + 1) % positions.Count;
         
         
        }
    }

}
