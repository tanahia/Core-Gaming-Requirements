using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HS_BarControl : MonoBehaviour
{
    public Slider slider;
    public Image image;
    public RectTransform rectTransform;



    void Start()
    {
        if (slider != null)
        {
            SetBarPosition(new Vector2(-300, -220));
        }
    }

        

        // Update is called once per frame
        void Update()
        {
            BarColourChange();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetBarValue(30.5);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SetBarValue(90);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           IncrementBar(10);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ReduceBar(10);
        }


    }
    

    /// <summary>
    /// Allows a health bars colour to 
    /// change between green, yellow and red, 
    /// depending on the sliders value
    /// </summary>
    public void BarColourChange()
    {
        float percentage = slider.value;
        int fullHealth = 65;
        int midHealth = 30;

        //changes the bar colour to green, when between
        //the full health margin, and the full bar
        if (percentage >= fullHealth)
        {
            image.color = Color.green;
        }

        //changes the bar colour to yellow when below
        //the full health margin, but not below the mid
        //health margin
        if (percentage < fullHealth && percentage >= midHealth)
        {
            image.color = Color.yellow;
        }

        //changes the bar colour to red when below the
        //mid health margin
        if (percentage < midHealth)
        {
            image.color = Color.red;
        }
    }
    /// <summary>
    /// Sets the bars position to the postion given in the parameter
    /// </summary>
    /// <param name="position">position of object as a Vector2</param>
    public void SetBarPosition(Vector2 position)
    {
        if (rectTransform != null)
        {
            rectTransform.anchoredPosition = position;
        }

    }
    /// <summary>
    /// Sets the bars value to a specified value
    /// </summary>
    /// <param name="value">The given value as a double</param>
    public void SetBarValue(double value)
    {
        slider.value = (float)value;
    }
    /// <summary>
    /// Increments a bar by the specified amount
    /// </summary>
    /// <param name="value">The given value that the bar will increase by as a double</param>
    public void IncrementBar(double value)
    {
        slider.value += (float)value;
    }

    /// <summary>
    /// Reduces a bar by the specified amount
    /// </summary>
    /// <param name="value">The given value that the bar will decrease by as a double</param>
    public void ReduceBar(double value)
    {
        slider.value -= (float)value;
    }

    /*public void BarDrain(double value, double speed)
    {

        StartCoroutine(slider.value -= (float)value;);
           
        
    }*/
}
