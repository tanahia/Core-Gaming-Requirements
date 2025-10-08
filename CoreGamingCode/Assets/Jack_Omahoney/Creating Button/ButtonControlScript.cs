using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControlScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPosition(Vector3 position)
    {
        //gets the rect transform component of the text object
        RectTransform rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.position = position;
        }
    }

    public void SetColors(Color normal, Color highlighted, Color pressed, Color disabled)
    {
        Button btn = GetComponent<Button>();
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
    public void SetButtonText(string text)
    {
       

    }
}
