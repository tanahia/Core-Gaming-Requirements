using UnityEngine;
using TMPro;

public class TimerUser : MonoBehaviour
{
    float time;

    public TextMeshProUGUI timerText;

    private MAR_TimerScript timer;

    void Start()
    {
        timer = gameObject.AddComponent<MAR_TimerScript>();
        timer.InitialiseTimer(5f);
        timer.StartTimer();
    }

    void Update()
    {
        time = timer.GetTimeRemaining();

        if (time > 0)
        {
            timerText.text = time.ToString("0.00");  
        }
        else
        {
            timerText.text = "DONE!";

        }
    }
}
