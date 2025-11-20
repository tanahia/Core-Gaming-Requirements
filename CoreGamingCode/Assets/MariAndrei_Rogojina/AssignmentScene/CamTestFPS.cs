using UnityEngine;

public class CamTestFPS : MonoBehaviour
{
    YB_CameraControlFPS cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main.transform.GetComponent<YB_CameraControlFPS>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.RotateHorizontal(Input.GetAxis("HorizontalM"));
        cam.RotateVertical(Input.GetAxis("VerticalM"));
    }
}
