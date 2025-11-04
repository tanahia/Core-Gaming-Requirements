using UnityEngine;
using UnityEngine.UI;

// TODO: Make validation for methods (at the end)
// TODO: Finish safety component (auto configuration)
// TODO: Implement method SetSize()
// TODO: Implement method InnerRadius()
// TODO: Implement method QuickSetUp()
// TODO: Implement method Reset()
// TODO: Implement SetPosition()

// Testing Feedback:
// 1. Canvas usagemention (docs)

/// <summary>
/// This class provides methods to manipulate Pie Chart GameObject. By default, has only 1 segment.
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
        if (autoConfigure)
        {
            _background.type = Image.Type.Simple;
            _segment.type = Image.Type.Filled;
            _segment.fillMethod = Image.FillMethod.Radial360;
            _segment.fillClockwise = false;
        } else
        {
            // Method Testing - erase before commiting
        }
    }

    /// <summary>
    /// Sets filling direction of the Pie Chart segment (single segment Pie Chart).
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
                Debug.LogWarning($"Invalid direction value: {direction}");
                break;
        }
    }
    
    /// <summary>
    /// Sets the fill percentage of Pie Chart segment (singe segment Pie Chart).
    /// </summary>
    /// <param name="value">fill percentage value from 1 to 100</param>
    public void SetSegmentPercentage(float value)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }
        _segment.fillAmount = value / 100f;
    }

    /// <summary>
    /// Sets the fill value of Pie Chart segment (singe segment Pie Chart).
    /// </summary>
    /// <param name="value">fill value from 0 to 1</param>
    public void SetSegmentValue(float value)
    {
        if (!_variablesInitialised)
        {
            InitialiseVariables();
        }
        _segment.fillAmount = value;
    }

    /// <summary>
    /// Sets the fill and max values of Pie Chart segment (single segment Pie Chart).
    /// </summary>
    /// <param name="value">value of segment (from 0 to max)</param>
    /// <param name="max">custom max value of segment (from 1 to 100)</param>
    public void SetSegmentValue(float value, float max)
    {
        float onePart = 100f / max;
        value = (onePart * value) / 100f;
        SetSegmentValue(value);
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
            Debug.LogWarning($"Invalid hex color: {color}");
        }
    }

    /// <summary>
    /// Sets color for segment of Pie Chart (singe segment Pie Chart).
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
            Debug.LogWarning($"Invalid hex color: {color}");
        }
    }
    
}
