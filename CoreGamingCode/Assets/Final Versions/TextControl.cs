using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextControl:MonoBehaviour
{
    /// <summary>
    /// Must be used with the TextObject Prefab
    /// 
    /// First Instantiate an instance of the Text Object Prefab
    /// Second Cache this script by using myText = GetComponent<TextControl>();
    /// 
    /// Call any of the below public methods to use
    /// 
    /// SetText
    /// SetPosition
    /// Blink
    /// SetColor
    /// StartColorTransition
    /// SetFont
    /// SetFontSize
    /// 
    /// </summary>




    bool isBlinking = false;
    float m_lowOpacity, m_HighOpacity, m_Period, t;
    float dir = 1f;


    // Color transition variables, public so I can change it on the component
    public Color startColor;
    public Color endColor;
    public float colorTransitionDuration;
    public bool enableColorTransition = false;


    private List<TMP_FontAsset> allFonts;


    TMPro.TextMeshPro m_TextMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        loadAllFonts();

    }



    private void loadAllFonts()
    {
        allFonts = new List<TMP_FontAsset>();
        object[] fonts = Resources.LoadAll("hold", typeof(Font));
        foreach (var newFont in fonts)
        {
            TMP_FontAsset asset = TMP_FontAsset.CreateFontAsset(newFont as Font);
            allFonts.Add(asset);

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isBlinking)
        {
            t += dir * Time.deltaTime;
            if (t > m_Period)
            {
                dir = -1;
                t = m_Period;
            }
            if (t < 0)
            {
                dir = 1;
                t = 0;
            }
            m_TextMeshPro.alpha = Mathf.Lerp(m_lowOpacity, m_HighOpacity, t / m_Period);

        }


        if (enableColorTransition && m_TextMeshPro != null)
        {
            float t = Mathf.PingPong(Time.time / (colorTransitionDuration / 2f), 1f); // This method I found through chatGPT, it's a method that loops between 2 numbers
            m_TextMeshPro.color = Color.Lerp(startColor, endColor, t); //I have learnt about color lerp through a few tutorials, its what I use to smoothly transition colors 
        }
    }
    /// <summary>
    /// Allows the text to be assigned
    /// </summary>
    /// <param name="text">new text</param>
    public void SetText(string text)
    {
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }
        m_TextMeshPro.text = text;
    }

    //

    /// <summary>
    /// this sets the position of the text object and sets it to the position passed in
    /// </summary>
    /// <param name="position">position of object as a Vector3</param>
    public void SetPosition(Vector3 position)
    {
        //gets the rect transform component of the text object
        RectTransform rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.position = position;
        }
    }

    /// <summary>
    /// Causes text to change between the lowest and highest opacity provided over the chosen period of time
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

    public void StartColorTransition(Color in_startColor, Color in_endColour, float duration)
    {
        colorTransitionDuration = duration;
        startColor = in_startColor;
        endColor = in_endColour;
        enableColorTransition = true;

    }


    public void SetFont(int fontIndex)
    {
        try
        {//catching invalid inputs
            if (m_TextMeshPro == null)
            {
                m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
            }
            //code that assigns font manually(from script)

            if (allFonts == null)
            {
                loadAllFonts();
            }
            m_TextMeshPro.font = allFonts[fontIndex];

        }
        catch
        {
            Debug.LogError("You can only use fonts that are from a specific list of fonts provided in 'Resources' folder. These fonts are Arial, BitcountInk, OpenSans, Oswald, Tillana, TiltPrism, TimesNewRoman");
        }
    }

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
