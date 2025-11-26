using UnityEngine;

public class TestCameraScript : MonoBehaviour
{
    private GT_CameraControlTPA cam;

    void Start()
    {
        // Get the camera script on this same camera
        cam = GetComponent<GT_CameraControlTPA>();
    }

    void Update()
    {

        float mouseY = -Input.GetAxis("Mouse Y") * 2f;
      
        cam.verticalRotate(mouseY);
    }
}
