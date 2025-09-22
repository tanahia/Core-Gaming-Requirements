using System;
using TMPro;
using UnityEngine;

public class YB_TextControlScript : MonoBehaviour
{
    bool isBlinking = false;
    float m_lowOpacity, m_HighOpacity, m_Period, t;
    float dir = 1f;

    TMPro.TextMeshPro m_TextMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
       if (isBlinking)
        {
            t += dir * Time.deltaTime;
            if (t>m_Period)
            {
                dir = -1;
                t = m_Period;
            }
            if (t < 0)
            {
                dir = 1;
                t = 0;
            }
            m_TextMeshPro.alpha = Mathf.Lerp(m_lowOpacity, m_HighOpacity, t/m_Period);

        }
    }

    public void SetText(string text)
    {
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }
        m_TextMeshPro.text = text;
      
    }
    /// <summary>
    /// Causes text to change between the lowest and highest opacity set over a period of time
    /// </summary>
    /// <param name="lowOpacity"> most transparent </param>
    /// <param name="highOpacity"> most opaque </param>
    /// <param name="period"> time interval </param>
    internal void Blink(float lowOpacity, float highOpacity, float period)
    {
        isBlinking = true;
        m_lowOpacity = lowOpacity;
        m_HighOpacity = highOpacity;    
        m_Period = period;
    }
}
