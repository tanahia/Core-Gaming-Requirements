 using UnityEngine;

public class SF_MovementTest : MonoBehaviour
{
   public SF_CharacterMovement characterTransform;

    float speedMovement = 100.0f;
    float rotationSpeed = 100.0f;
    float horizontalInput;
    float verticalInput;

    void Start()
    {
        characterTransform = GetComponent<SF_CharacterMovement>();

        //characterTransform.SetPosition(new Vector3(0, 15, 0));
        //characterTransform.setScale(new Vector3(5, 5, 5));     
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        characterTransform.keyboardRotation(horizontalInput, verticalInput, rotationSpeed);

        if (Input.GetKey(KeyCode.W))
        {
            characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);

            //moveForward(speedMovement);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);
            //  characterTransform.moveBackwards(speedMovement);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);
            // characterTransform.moveRight(speedMovement);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);
            // characterTransform.moveLeft(speedMovement);
        }
        else if (Input.GetKey(KeyCode.F))
        {
            characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);
            //  characterTransform.turnLeft(rotationSpeed);
        }

    }

}

