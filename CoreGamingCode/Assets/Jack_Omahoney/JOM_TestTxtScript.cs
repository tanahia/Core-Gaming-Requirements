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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform temp = Instantiate(textGOCloneTemplate);
            JOM_txtcontrolscript MyTempText = temp.GetComponent<JOM_txtcontrolscript>();
            MyTempText.SetText("Clone No " +  i.ToString());
            i++;
        }
    }

}
