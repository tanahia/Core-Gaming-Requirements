using UnityEngine;

public class YB_TestScript : MonoBehaviour
{
    int direction = 0;
    float percentage = 75;
    string hexBGColour = "#000000", hexSegmentColour = "#ffffff";

    Canvas canvas;

    public Transform pieChartCloneTemplate;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform newPieChartGO = Instantiate(pieChartCloneTemplate,canvas.transform,false);

            MTPieChart piecharttest = newPieChartGO.GetComponent<MTPieChart>();

            piecharttest.SetDirection(direction);

            piecharttest.SetSegmentPercentage(UnityEngine.Random.Range(0,100));

            piecharttest.SetBgColor(hexBGColour);

            piecharttest.SetSegmentColor(hexSegmentColour);
        }



    }
}
