using UnityEngine;

public class SF_MovementTestforCamera : MonoBehaviour
{
    float rotationSpeed = 200.0f;
    float rotationX;
    float rotationY;
    float sensitivity = 2.0f;
    public SF_CharacterMovement characterTransform;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        characterTransform = GetComponent<SF_CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
        characterTransform.mouseRotation(rotationX, rotationY);

    }
}
