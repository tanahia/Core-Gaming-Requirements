using UnityEngine;

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

    public void RotateHorizontal(float diff)
    {
        horzRotation += diff;
    }

    public void RotateVertical(float diff) 
    { 
        vertRotation -= diff;
        vertRotation = Mathf.Clamp(vertRotation, minAngle, maxAngle);
    }
}
