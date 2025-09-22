using TMPro;
using UnityEngine;

public class FontScript : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;
    [SerializeField] string nameOfFont;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        SetFont();
    }
    public void SetFont()
    {
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        }
       Font newFont = Resources.Load<Font>(nameOfFont);
        TMP_FontAsset asset = TMP_FontAsset.CreateFontAsset(newFont);
        m_TextMeshPro.font = asset;
    }
}
