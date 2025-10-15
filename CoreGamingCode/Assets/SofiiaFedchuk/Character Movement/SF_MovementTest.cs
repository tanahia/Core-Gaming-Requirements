using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.U2D.ScriptablePacker;

public class SF_MovementTest : MonoBehaviour
{
   public SF_CharacterMovement characterTransform;
    public Transform cameraHolder;


    float speedMovement = 100.0f;
    float rotationSpeed = 200.0f;
    float horizontalInput;
    float verticalInput;
    float rotationX;
    float rotationY;
    float sensitivity = 2.0f;


    void Start()
    {
        characterTransform = GetComponent<SF_CharacterMovement>();

        characterTransform.SetPosition(new Vector3(0, 10, 0));
        characterTransform.setScale(new Vector3(20, 20, 20));
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        characterTransform.keyboardRotation(horizontalInput, verticalInput, rotationSpeed);


        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
        cameraHolder.localRotation = Quaternion.Euler(rotationX, rotationY, 0);


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
