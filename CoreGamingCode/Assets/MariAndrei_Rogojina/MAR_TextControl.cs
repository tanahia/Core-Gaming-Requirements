using UnityEngine;

public class MAR_TextControl : MonoBehaviour
{
    private TMPro.TextMeshPro m_TextMeshPro;

    // Color transition variables, public so I can change it on the component
    public Color startColor = Color.white;
    public Color endColor = Color.red;
    public float colorTransitionDuration = 2f;
    public bool enableColorTransition = false; 

    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enableColorTransition && m_TextMeshPro != null)
        {
            float t = Mathf.PingPong(Time.time / (colorTransitionDuration / 2f), 1f); // This method I found through chatGPT, it's a method that loops between 2 numbers
            m_TextMeshPro.color = Color.Lerp(startColor, endColor, t); //I have learnt about color lerp through a few tutorials, its what I use to smoothly transition colors 
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


    public void StartColorTransition(Color in_startColor, Color in_endColour, float duration)
    {
        colorTransitionDuration = duration;
        startColor = in_startColor;
        endColor = in_endColour;
        enableColorTransition = true;

    }
    
}