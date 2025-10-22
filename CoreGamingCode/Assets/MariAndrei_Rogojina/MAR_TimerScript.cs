using UnityEditor.SceneManagement;
using UnityEngine;

public class MAR_TimerScript : MonoBehaviour
{
    private float m_Time;         // Start time in seconds ( Change it to shorten or lengthen the timer )
    private bool m_Running = false;      // Is the timer running?
    private bool m_Paused = false;       // Is the timer paused?
    private float m_TimeRemaining;       // Current time count

    void Start()
    {
        /* TO USE THIS SCRIPT YOU GET COMPONENT USING
        MAR_TimerScript cooldown = transform.gameObject.AddComponent<MAR_TimerScript>();
        ----------------- ^ Rename to whatever purpose you want
        cooldown.InitialiseTimer(5f); <--- "5f" is the duration of the timer, you can change it to anything else you want
        cooldown.Start(); 
        cooldown.PauseTimer(); <--- Pauses timer and keeps timer duration, can use get TimeRemaining() to check this
        cooldown.StartTimer();
        cooldown.StopTimer

        if (cooldown.GetTimeRemaining() > 0) */

        // ^ Use above for testing different purposes
        

            StartTimer(); // Start timer
    }

    void Update()
    {
        if (m_Running && !m_Paused)
        {
            m_Time -= Time.deltaTime;

            if (m_Time <= 0f)
            {
                m_Time = 0f;
                m_Paused = true;
                m_Running = false;
                m_TimeRemaining = m_Time;
                // print("Timer finished. Time remaining: " + m_TimeRemaining);
            }
        }
    }

    public void StartTimer()
    {
        m_Running = true;
        m_Paused = false;
    }

    public void PauseTimer() // Pauses the timer but maintains the time count
    {
        m_Paused = true;
        // print("Timer paused. Time remaining: " + m_TimeRemaining);
    }

    public void ResumeTimer() // Starts the timer with the previous time cout
    {
        if (m_Time > 0f)
        {
            m_Paused = false;
            // print("Timer started.");
        }
    }

    public void StopTimer() // Stops the timer
    {
        m_Running = false;
        // print("Timer stopped.");
    }

    public void InitialiseTimer(float duration)
    {
        m_Time = duration;

    }

    public float GetTimeRemaining() // Get the current time left out of the timer
    {
        return m_Time; 
    }
}