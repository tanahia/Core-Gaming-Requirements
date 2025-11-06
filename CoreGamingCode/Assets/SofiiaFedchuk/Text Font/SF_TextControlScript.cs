using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class SF_TextControlScript : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;
    private List<TMP_FontAsset>  allFonts;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();

        loadAllFonts();
    }

    private void loadAllFonts()
    {   allFonts = new List<TMP_FontAsset> ();
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

        
    }
    public void Set_Text(string text)
    {
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }
        m_TextMeshPro.text = text;
    }
    public void SetFont()
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
            m_TextMeshPro.font = allFonts[Random.Range(0, allFonts.Count)];

        }
        catch
        {
            Debug.LogError("You can only use fonts that are from a specific list of fonts provided in 'Resources' folder. These fonts are Arial, BitcountInk, OpenSans, Oswald, Tillana, TiltPrism, TimesNewRoman");
        }
    }
}

