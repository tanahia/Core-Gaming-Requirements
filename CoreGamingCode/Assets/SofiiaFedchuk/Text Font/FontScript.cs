using System;
using TMPro;
using UnityEngine;

public class FontScript : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;

    /* SerializedField attribute makes variable accessable from Unity Inspector;
     The field is located in Script component(Font Script) and displayed as 'Name Of Font';
    The list of fonts that are available for Testing:
    Arial
    BitcountInk
    OpenSans
    Oswald
    Tillana
    TiltPrism
    TimesNewRoman
    All fonts should be written with the same style as fonts above
    */
    [SerializeField] string _nameOfFont;
   
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
    }

   
    void Update()
    {
        SetFont();
    }
    public void SetFont()
    {
        try {//catching invalid inputs
            if (m_TextMeshPro == null)
            {
                m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
            }
            //code that assigns font manually(from script)
            Font newFont = Resources.Load<Font>(_nameOfFont);
            TMP_FontAsset asset = TMP_FontAsset.CreateFontAsset(newFont);
            m_TextMeshPro.font = asset;
        }
        catch
        {
            Debug.LogError( "You can only use fonts that are from a specific list of fonts provided in 'Resources' folder. These fonts are Arial, BitcountInk, OpenSans, Oswald, Tillana, TiltPrism, TimesNewRoman");
        }
     }
}
