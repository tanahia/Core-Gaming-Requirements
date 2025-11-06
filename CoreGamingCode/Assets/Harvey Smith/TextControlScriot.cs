using UnityEngine;
using TMPro;

public class TextControlScriot : MonoBehaviour
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

    public void SetText(string text)
    {
        if (m_TextMeshPro == null)
        {m_TextMeshPro = GetComponent<TMPro.TextMeshPro> ();

        }
        m_TextMeshPro.text = text;
    }

    /// <summary>
    /// Changes the font size of TMPro Component , i.e. must have TMPro component to work 
    /// </summary>
    /// <param name="fontSize">The font size value</param>
    public void SetFontSize(float fontSize)
        {
            if (m_TextMeshPro == null)
            {
                m_TextMeshPro = GetComponent<TextMeshPro>();
            }

            float randomSize = fontSize;
            m_TextMeshPro.fontSize = randomSize;
        }
    }

