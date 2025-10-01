using UnityEngine;

public class MS_TextControl : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {

    }
/// <summary>
/// Sets Text of TMPro Component , i.e. must have TMPro component to work 
/// </summary>
/// <param name="text">New Text to be displayed</param>
    public void SetText(string text)
    {
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }
        m_TextMeshPro.text = text;
    }

/// <summary>
/// Changes the color of TMPro Component, i.e. must have TMPro componet to work
/// </summary>
/// <param name="color">The color value</param>
    public void SetColor(Color color)
    {
        // write set color method color here
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }

        m_TextMeshPro.color = color;
    }
}
