using UnityEngine;

public class YB_testfpscam : MonoBehaviour
{


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
    }
}
