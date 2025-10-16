using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HS_BarControl : MonoBehaviour
{
    Slider slider;
    RectTransform rectTransform;
    Image image;
    bool initialised = false;


    void Start()
    {
        initialize();
    }

    private void initialize()
    {
        slider = GetComponent<Slider>();
        if (slider) print("Slider Success");
        Image[] imgs = GetComponentsInChildren<Image>();
        image = imgs[1];

        rectTransform = GetComponent<RectTransform>();
        if (rectTransform) print("RectTransform Success");
        initialised = true;
    }



    // Update is called once per frame
    void Update()
        {
      


    }


    /// <summary>
    /// This method changes the colour of the bar, to a specified colour at a specified value
    /// </summary>
    /// <param name="fullHealth">The value of which the full health colour stops</param>
    /// <param name="middleHealth">The value of which the medium health stops</param>
    /// <param name="fullHealthColor">The colour when above or equal to the full health value</param>
    /// <param name="middleHealthColor">The colour when above or equal to the middle health value</param>
    /// <param name="lowHealthColor">The colour when below the middle health value</param>
    public void BarColourChange(double fullHealth, double middleHealth, Color fullHealthColor, Color middleHealthColor, Color lowHealthColor)
    {
        if (!initialised) initialize();

        float percentage = slider.value;
        

        //changes the bar colour to the specified color, when between
        //the full health margin, and the full bar
        if (percentage >= fullHealth)
        {
            image.color = fullHealthColor;
        }

        //changes the bar colour to the specified color when below
        //the full health margin, but not below the mid
        //health margin
        if (percentage < fullHealth && percentage >= middleHealth)
        {
            image.color = middleHealthColor;
        }

        //changes the bar colour to the specified color when below the
        //mid health margin
        if (percentage < middleHealth)
        {
            image.color = lowHealthColor;
        }
    }

    /// <summary>
    /// Changes the colour of the bar (No changing)
    /// </summary>
    /// <param name="color">The desired colour</param>
    public void BarColour(Color color)
    {
        if (!initialised) initialize();
        image.color = color;
    }
    /// <summary>
    /// Sets the bars position to the postion given in the parameter
    /// </summary>
    /// <param name="position">position of object as a Vector2</param>
    public void SetBarPosition(Vector2 position)
    {
        if (!initialised) initialize();

 
        rectTransform.anchoredPosition = position;
    }
    /// <summary>
    /// Sets the bars value to a specified value
    /// </summary>
    /// <param name="value">The given value as a double</param>
    public void SetBarValue(double value)
    {
        if (!initialised) initialize();
        slider.value = (float)value;
    }
    /// <summary>
    /// Increments a bar by the specified amount
    /// </summary>
    /// <param name="value">The given value that the bar will increase by as a double</param>
    public void IncrementBar(double value)
    {
        if (!initialised) initialize();
        slider.value += (float)value;
    }

    /// <summary>
    /// Reduces a bar by the specified amount
    /// </summary>
    /// <param name="value">The given value that the bar will decrease by as a double</param>
    public void ReduceBar(double value)
    {
        if (!initialised) initialize();
        slider.value -= (float)value;
    }

    /*public void BarDrain(double value, double speed)
    {

        StartCoroutine(slider.value -= (float)value;);
           
        
    }*/
}
