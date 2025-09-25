using System.Collections.Generic;
using UnityEngine;

public class PositionScript : MonoBehaviour
{
    int i = 0;
    int clonecycle = 0;

    //This creates is a list of Vector3 positions that the text will be moved to
    List<Vector3> positions;

    public Transform textGOCloneTemplate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This code uses positions.add to add positions you define to a list
        positions = new List<Vector3>();
        positions.Add(new Vector3(-15, 5, 0));
        positions.Add(new Vector3(15, 5, 0));
        positions.Add(new Vector3(15, -14, 0));
        positions.Add(new Vector3(-15, -14, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            PositionControlScript myTempText = temp.GetComponent<PositionControlScript>();
            myTempText.Set_Text("Clone No. " + i.ToString());

            //This sets the position of the text using the list of positions defined in start
            myTempText.SetPosition(positions[clonecycle]);


            i++;

            //Here +1 is added to the clonecycle to move on to the next position in the list
            clonecycle = (clonecycle + 1) % positions.Count;
        }
    }
}
