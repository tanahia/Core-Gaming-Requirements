using System;
using UnityEngine;

public class ColourTest : MonoBehaviour
{
    
    TMPro.TextMeshPro m_TextMeshPro;
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        m_TextMeshPro.GetComponent<MS_TextControl>().SetColor(Color.red);
        // GetComponent<MS_TextControl>().SetColor(Color.red);    
    }

    void Update()
    {
        
    }
}
