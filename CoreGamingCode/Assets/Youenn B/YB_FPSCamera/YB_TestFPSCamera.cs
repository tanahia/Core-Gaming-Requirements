using UnityEngine;

public class YB_testfpscam : MonoBehaviour
{
    float cameraX = 0, cameraY = 0, camLimitX = -60, camLimitY = 65;

    YB_CameraControlFPS fpsCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fpsCam = FindAnyObjectByType<YB_CameraControlFPS>();
        
    }

    // Update is called once per frame
    void Update()
    {
        fpsCam.RotateHorizontal( Input.GetAxis("Horizontal"));

        fpsCam.RotateVertical( Input.GetAxis("Vertical"));

       if(Input.GetKey(KeyCode.Tab))
        {
            fpsCam.SetCameraOrientation(cameraX, cameraY);
        }

        if(Input.GetKey(KeyCode.F1)) 
        {
            fpsCam.SetCameraAngleLimit(camLimitX,camLimitY);
        }

        //CameraControlFPS attaches to the camera and TestFPSCamera goes on the player
    }
}
