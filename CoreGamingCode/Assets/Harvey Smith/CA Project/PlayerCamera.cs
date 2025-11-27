using UnityEngine;

public class TestCameraScript : MonoBehaviour
{
    private GT_CameraControlTPA cam;
    float mouseY;
    float mouseX;

    void Start()
    {
        // Get the camera script on this same camera
        cam = GetComponent<GT_CameraControlTPA>();
    }

    void Update()
    {

       // mouseY = -Input.GetAxis("Mouse Y") * 2f;
       // cam.verticalRotate(mouseY);

        mouseX = -Input.GetAxis("Mouse X") * 2f;
        cam.lateralRotate(mouseX);

        cam.setScroll(75, 80);
    }
}
