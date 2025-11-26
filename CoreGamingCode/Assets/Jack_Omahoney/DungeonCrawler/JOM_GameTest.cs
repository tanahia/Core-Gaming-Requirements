using UnityEngine;

public class GameTest : MonoBehaviour
{
    public SF_CharacterMovement characterTransform;
    GT_CameraControlTPA PlayerCam;
    float speedMovement = 10.0f;
    float rotationSpeed = 1050.0f;
    float horizontalInput;
    float verticalInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerCam = FindAnyObjectByType<GT_CameraControlTPA>();
        characterTransform = GetComponent<SF_CharacterMovement>();
        characterTransform.SetPosition(new Vector3(0, 1, 0));
        characterTransform.setScale(new Vector3(1, 1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        characterTransform.keyboardRotation(horizontalInput, verticalInput, rotationSpeed);
        PlayerCam.lateralRotate(Input.GetAxis("Mouse X"));
        PlayerCam.verticalRotate(Input.GetAxis("Mouse Y"));

        if (Input.GetKey(KeyCode.W))
        { 
            characterTransform.moveForward(speedMovement);
        }
        else if (Input.GetKey(KeyCode.S))

        {
            characterTransform.moveBackwards(speedMovement);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            characterTransform.moveRight(speedMovement);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            characterTransform.moveLeft(speedMovement);
        }
    }
}
