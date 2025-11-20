using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    GT_CameraControlTPA playerCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCam.GetComponent<GT_CameraControlTPA>();


       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
