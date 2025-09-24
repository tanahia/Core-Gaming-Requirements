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

    public void SetFontSize(float i)
        {
            if (m_TextMeshPro == null)
            {
                m_TextMeshPro = GetComponent<TextMeshPro>();
            }

            float randomSize = Random.Range(1f, 19f);
            m_TextMeshPro.fontSize = randomSize;
        }
    }

