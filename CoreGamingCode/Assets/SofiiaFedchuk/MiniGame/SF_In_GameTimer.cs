using System;
using Unity.VisualScripting;
using UnityEngine;

public class SF_In_GameTimer : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;
    MAR_TimerScript timer;
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        timer = transform.gameObject.AddComponent<MAR_TimerScript>();
        timer.InitialiseTimer(300f);
        timer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.GetTimeRemaining() > 0)
        {
            Set_Text(timer.GetTimeRemaining());
        }
        else
        {
            timer.StopTimer();
        }
    }
    public void Set_Text(float time_remaining)
    {

        int minute, second;
        string text;
        (minute, second) = getMinSec(time_remaining);



        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }
        else
        {
            text = minute + " : " + second;
            m_TextMeshPro.text = text;
        }

    }

    private (int minute, int second) getMinSec(float time_remaining)
    {
        float minutes = time_remaining / 60;
        int min = Mathf.FloorToInt(minutes);
        int sec = (int)time_remaining - min * 60;
        return (min, sec);
    }
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name == "GateEnd")
            print("stop");
            timer.StopTimer();

    }
}
