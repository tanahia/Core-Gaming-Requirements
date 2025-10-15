using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControlScript : MonoBehaviour
{
    /// <summary>
    /// Assigns in inspecter or finds automatically
    /// </summary>
    Button btn;
    TextMeshProUGUI Buttontext;
    private bool ready;
    RectTransform rectTransform;
    Image img;
   

    /// <summary>
    /// Automatically finds the TextMeshProUGUI component inside button
    /// </summary>
    void Start()
    {       
        if (btn != null)
        {
            Buttontext = btn.GetComponentInChildren<TextMeshProUGUI>();
        }
    }

   
    void Update()
    {
        
    }
    /// <summary>
    /// Sets the position of the button to the position passed in
    /// </summary>
    /// <param name="position"></param>
    public void SetPosition(Vector3 position)
    {
        //gets the rect transform component of the text object
        rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.anchoredPosition = position;
        }
    }

    /// <summary>
    /// Sets the colors of the button to the colors passed in
    /// </summary>
    /// <param name="normal"></param>
    /// <param name="highlighted"></param>
    /// <param name="pressed"></param>
    /// <param name="disabled"></param>
    public void SetColors(Color normal, Color highlighted, Color pressed, Color disabled)
    {
         btn = GetComponent<Button>();
        if (btn != null)
        {
            ColorBlock cb = btn.colors;
            cb.normalColor = normal;
            cb.highlightedColor = highlighted;
            cb.pressedColor = pressed;
            cb.disabledColor = disabled;
            btn.colors = cb;
        }
    }

    /// <summary>
    /// Sets the text of the button to the string passed in
    /// </summary>
    /// <param name="newtext"></param>
    public void SetButtonText(string newtext)
    {
        if(!ready)
            Initilise();

        
            Buttontext.text = newtext;
        
        
      
    }

    /// <summary>
    /// Sets the size of the button to the width and height passed in
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public void SetButtonSize(float width, float height)
    {
        rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.sizeDelta = new Vector2(width, height);
        }
    }

    /// <summary>
    /// Sets the image of the button to the sprite passed in
    /// </summary>
    /// <param name="newSprite"></param>
    public void SetButtonImage(Sprite newSprite)
    {
        if (btn != null && newSprite != null)
        {
      
            if (img != null)
            {
                img.sprite = newSprite;
            }
        }
    }

    internal void Initilise()
    {
        btn = GetComponent<Button>();
        Buttontext = btn.GetComponentInChildren<TextMeshProUGUI>();
        img = btn.GetComponent<Image>();
        ready = true;

    }
}
