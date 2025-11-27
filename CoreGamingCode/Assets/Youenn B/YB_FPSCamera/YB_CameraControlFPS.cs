using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.Image;

public class YB_CameraControlFPS : MonoBehaviour
{
    float horzRotation, vertRotation;

    public Transform myChar;
    private float minAngle = -80;
    private float maxAngle = 80;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = myChar.position;
        transform.rotation = Quaternion.Euler(vertRotation, horzRotation, 0f);
    }
    //CameraControlFPS attaches to the camera and TestFPSCamera goes on the player

    /// <summary>
    /// Rotates camera horizontally
    /// </summary>
    /// <param name="diff"></param>
    public void RotateHorizontal(float diff)
    {
        horzRotation += diff;
    }


    /// <summary>
    /// rotates camera vertically
    /// </summary>
    /// <param name="diff"></param>
    public void RotateVertical(float diff)
    {
        vertRotation -= diff;
        vertRotation = Mathf.Clamp(vertRotation, minAngle, maxAngle);
    }


    /// <summary>
    /// Locks camera in place
    /// </summary>
    /// <param name="lookX"></param>
    /// <param name="lookY"></param>
    public void SetCameraOrientation(float lookX, float lookY)
    {
        vertRotation = lookX;
        horzRotation = lookY;
    }


    /// <summary>
    /// changes the limit of the cameras vertical  rotation, default min -80 & max 80
    /// </summary>
    /// <param name="setMin"></param>
    /// <param name="setMax"></param>
    public void SetCameraAngleLimit(float setMin, float setMax)
    {
        minAngle = setMin;
        maxAngle = setMax;
    }

    
}