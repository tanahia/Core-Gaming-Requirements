using UnityEngine;

public class YB_CameraControlFPS : MonoBehaviour
{
    float horzRotation, vertRotation;

    public Transform myChar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        transform.position = myChar.position;

        transform.Rotate(Vector3.up, horzRotation);
        transform.Rotate(Vector3.right, vertRotation);

    }

    public void RotateHorizontal(float diff)
    {
        horzRotation = diff;
    }

    public void RotateVertical(float diff) 
    { 
        vertRotation = diff;
    }
}
//When camera moves it also rotates in an unintended way,
//it does not remain parallel with the ground