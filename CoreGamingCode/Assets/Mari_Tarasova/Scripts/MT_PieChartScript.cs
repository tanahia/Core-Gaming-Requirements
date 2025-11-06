using UnityEngine;
using UnityEngine.UI;

// TODO: Test class methods

/// <summary>
/// This class provides methods to manipulate Pie Chart GameObject. For proper usage of this GameObject it should be
/// child under the canvas.
/// </summary>
public class MTPieChart : MonoBehaviour {
    
    private Image _background;
    private Image _segment;
    bool _variablesInitialised = false;
    [Header("Safety")]
    [Space]
    [Tooltip("Mark to perform vital configuration of GameObject properly to work with this script")]
    [SerializeField] private bool autoConfigure; // sets type to Filled/Radial at runtime

    void Start()
    {
        InitialiseVariables();
    }

    private void InitialiseVariables()
    {
        // If you have renamed any image objects under PieChart game object - change Find() arguments to this
        // names, otherwise script won't work.

        _background = transform.Find("Background").GetComponent<Image>();
        _segment = transform.Find("Segment").GetComponent<Image>();
        _variablesInitialised=true;
    }

    void Update()
    {
        if (autoConfigure || _variablesInitialised)
        {
            _background.type = Image.Type.Simple;
            _segment.type = Image.Type.Filled;
            _segment.fillMethod = Image.FillMethod.Radial360;
        } else
        {
            InitialiseVariables();
        }

        if (_background.type != Image.Type.Simple 
            || _segment.type != Image.Type.Filled 
            || _segment.fillMethod != Image.FillMethod.Radial360)
        {
            autoConfigure = false;
        }
    }

    /// <summary>
    /// Sets filling direction of the Pie Chart segment.
    /// </summary>
    /// <param name="direction">0 for counter-clockwise direction, 1 for clockwise</param>
    public void SetDirection(int direction)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }

        switch (direction)
        {
            case 0:
                _segment.fillClockwise = false;
                break;
            case 1:
                _segment.fillClockwise = true;
                break;
            default:
                Debug.LogWarning($"Invalid direction value: {direction}. Direction value should be 0 or 1");
                break;
        }
    }
    
    /// <summary>
    /// Sets the fill percentage of Pie Chart segment.
    /// </summary>
    /// <param name="value">fill percentage value from 1 to 100</param>
    public void SetSegmentPercentage(float value)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }

        if (value is >= 1 or <= 100)
        {
            _segment.fillAmount = value / 100f;    
        } else {
            Debug.LogWarning($"Invalid percentage value: {value}. Percentage value should be from 1 to 100.");
        }

    }

    /// <summary>
    /// Sets the fill value of Pie Chart segment.
    /// </summary>
    /// <param name="value">fill value from 0 to 1</param>
    public void SetSegmentValue(float value)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }
        
        if (value is 0 or 1)
        {
            _segment.fillAmount = value;    
        } else {
            Debug.LogWarning($"Invalid value: {value}. Value should be 0 or 1.");
        }
    }

    /// <summary>
    /// Sets the fill and max values of Pie Chart segment.
    /// </summary>
    /// <param name="value">value of segment (from 0 to max)</param>
    /// <param name="max">custom max value of segment (from 1 to 100)</param>
    public void SetSegmentValue(float value, float max)
    {
        if (value <= max || value >= 0 || max > 0 || max ! > 100)
        {
            float onePart = 100f / max;
            value = (onePart * value) / 100f;
            SetSegmentValue(value);
        } else {
            Debug.LogWarning($"Invalid values: {value} & {max}. Values can't be more than max and less than 0. " +
                             $"Max value should be more than 0 and maximum 100.");
        }
    }
    
    /// <summary>
    /// Sets color for background of Pie Chart.
    /// </summary>
    /// <param name="color">hexadecimal value starting with hash</param>
    public void SetBgColor(string color)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }
        
        if (ColorUtility.TryParseHtmlString(color, out Color result))
        {
            _background.color = result;
        } else
        {
            Debug.LogWarning($"Invalid hex color: {color}. Should be hex value and start with hash.");
        }
    }

    /// <summary>
    /// Sets color for segment of Pie Chart.
    /// </summary>
    /// <param name="color">hexadecimal value starting with hash</param>
    public void SetSegmentColor(string color)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }
        
        if (ColorUtility.TryParseHtmlString(color, out Color result))
        {
            _segment.color = result;
        } else
        {
            Debug.LogWarning($"Invalid hex color: {color}. Should be hex value and start with hash.");
        }
    }

    /// <summary>
    /// Sets the size of the background of PieChart
    /// </summary>
    /// <param name="size">wished float value for the size</param>
    public void SetBgSize(float size)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }
        
        _background.transform.localScale = new Vector3(size, size, 1f);
    }
    
    /// <summary>
    /// Sets the size of the segment of PieChart
    /// </summary>
    /// <param name="size">wished float value for the size</param>
    public void SetSegmentSize(float size)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }
        
        _segment.transform.localScale = new Vector3(size, size, 1f);
    }

    /// <summary>
    /// Sets the size of PieChart
    /// </summary>
    /// <param name="size">value of x and y</param>
    public void SetSize(float size)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables(); 
        }

        transform.localScale = new Vector3(size, size, 1f);
    }

    /// <summary>
    /// Sets default values for the PieChart
    /// </summary>
    public void SetDefault()
    {
        SetSize(1); 
        SetSegmentColor("#ABD1C6");
        SetBgColor("#F5F5F5");
        SetSegmentValue(100);
        SetDirection(0);
    }
}
