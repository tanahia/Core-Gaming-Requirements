using UnityEngine;

public class SF_MouseRotation : MonoBehaviour
{
    public float mouseSensitivity = 200f;
    public float mouseX;
    public float mouseY;
    //float xRotation = 0f;
    public Transform player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MouseLook();
    }
    public void MouseLook()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


        // xRotation -= mouseY;
        // xRotation=Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation=Quaternion.Euler(xRotation,0,0);
        player.Rotate(Vector3.up * mouseX);

    }
}
