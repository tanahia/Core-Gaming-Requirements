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

    public void SetText(string text)
    {
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }
        m_TextMeshPro.text = text;
    }
}
