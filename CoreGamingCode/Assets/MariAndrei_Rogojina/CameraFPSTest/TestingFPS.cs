using UnityEngine;

public class TestingFPS : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        YB_CameraControlFPS cam = transform.GetComponent<YB_CameraControlFPS>();
        cam.RotateHorizontal(90f);
        cam.RotateVertical(90f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
