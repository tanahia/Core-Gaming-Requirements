using UnityEngine;

public class Game1_Script : MonoBehaviour
{
    YB_CameraControlFPS cam2;
    HealthBar_Script_GT sprint;
    public Camera cam;
    private float normalFOV = 90f;
    private float zoomFOV = 115f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        cam2 = GetComponent<YB_CameraControlFPS>();
        sprint = GetComponent<HealthBar_Script_GT>();
        
 
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            if (cam.fieldOfView < zoomFOV)
                cam.fieldOfView += 4f;
        }
        else
        {
            if (cam.fieldOfView == zoomFOV || cam.fieldOfView > normalFOV)
                cam.fieldOfView -= 3f; // when Space is released
        }

    }
}
