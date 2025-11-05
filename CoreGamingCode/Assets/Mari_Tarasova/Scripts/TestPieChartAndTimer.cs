using UnityEngine;

public class TestPieChartAndTimer : MonoBehaviour
{
    public Transform PieChartTemp;
    private Canvas canvas;
    MAR_TimerScript timerScript;
    
    MTPieChart pieChart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas = FindAnyObjectByType<Canvas>();
        timerScript = gameObject.AddComponent<MAR_TimerScript>();
        timerScript.InitialiseTimer(5);
    }

    // Update is called once per frame
    void Update()
    {
        float timeRemaining = timerScript.GetTimeRemaining();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform PieChartGO = Instantiate(PieChartTemp, canvas.transform, false);
            pieChart = PieChartGO.GetComponent<MTPieChart>();
            timerScript.StartTimer();
            
        }

        if (timeRemaining > 0)
        {
            pieChart.SetSegmentValue(timeRemaining, 5);
        }
        
    }
}
