using UnityEngine;
using UnityEngine.UI;

public class Game1_Script : MonoBehaviour
{
    Vector3 lastMousePos;
    SF_MouseRotation cam2;
    public float sensitivity = 0.2f;
    float xRotation = 0f;

    public BarTest bar;
    private HS_BarControl health, stamina;

    public Image popupImage;
    public Camera cam;

    public Transform player;          // reference to player object
    public float bobFrequency = 10f;  // speed of bob
    public float bobAmount = 0.05f;   // intensity of bob

    private float normalFOV = 80f;
    private float zoomFOV = 100f;

    private Vector3 camStartPos;

    void Start()
    {
        Cursor.visible = false;
        lastMousePos = Input.mousePosition;
        cam2 = GetComponent<SF_MouseRotation>();
        camStartPos = cam.transform.localPosition;
        bar = GetComponent<BarTest>();


        Transform Health = Instantiate(bar.barClone);
        health = Health.GetComponentInChildren<HS_BarControl>();
        health.SetBarPosition(new Vector2(-750, 400));
    }

    void Update()
    {
        HandleMouseLook();
        HandleZoomAndPopup();
        HandleHeadBob();


        health.BarColourChange(90, 50, Color.green, Color.yellow, Color.red);
    }

    void HandleMouseLook()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        lastMousePos = Input.mousePosition;

        float mouseX = delta.x * sensitivity;
        float mouseY = delta.y * sensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        cam2.mouseSensitivity = 1000f;
        cam2.mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
    }

    void HandleZoomAndPopup()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (cam.fieldOfView < zoomFOV)
                cam.fieldOfView += 0.3f;
            popupImage.enabled = true;
        }
        else
        {
            if (cam.fieldOfView > normalFOV)
                cam.fieldOfView -= 0.3f;
            popupImage.enabled = false;
        }
    }

    void HandleHeadBob()
    {
        // Only bob if player is moving
        float horizontal = Input.GetAxis("Horizontal"); // A/D
        float vertical = Input.GetAxis("Vertical");     // W/S
        float speed = Mathf.Abs(horizontal) + Mathf.Abs(vertical);

        if (speed > 0)
        {
            float bobX = Mathf.Sin(Time.time * bobFrequency) * bobAmount;
            float bobY = Mathf.Cos(Time.time * bobFrequency * 2) * bobAmount;
            cam.transform.localPosition = camStartPos + new Vector3(bobX, bobY, 0);
        }
        else
        {
            // Reset to original position when not moving
            cam.transform.localPosition = Vector3.Lerp(cam.transform.localPosition, camStartPos, Time.deltaTime * 5f);
        }
    }


}
