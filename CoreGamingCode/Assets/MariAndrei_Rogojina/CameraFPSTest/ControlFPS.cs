using UnityEngine;

public class ControlFPS : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        YB_CameraControlFPS cam = transform.GetComponent<YB_CameraControlFPS>();
        cam.RotateVertical(1);
        cam.RotateHorizontal(1);
        cam.SetCameraAngleLimit(-80f, 80f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
