using UnityEngine;

public class GT_Test_CameraTPA : MonoBehaviour
{
    GT_CameraControlTPA myCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCam = FindAnyObjectByType<GT_CameraControlTPA>();
    }

    // Update is called once per frame
    void Update()
    {
       myCam.lateralRotate(Input.GetAxis("Horizontal"));
        myCam.verticalRotate(Input.GetAxis("Vertical"));
    }
}
