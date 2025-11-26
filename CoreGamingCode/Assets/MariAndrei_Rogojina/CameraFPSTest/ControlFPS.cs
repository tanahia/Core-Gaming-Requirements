using UnityEngine;

public class ControlFPS : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        YB_CameraControlFPS camControl = transform.GetComponent<YB_CameraControlFPS>();
        camControl.RotateVertical(2);
        camControl.RotateHorizontal(2);
        camControl.SetCameraAngleLimit(-80f, 80f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
