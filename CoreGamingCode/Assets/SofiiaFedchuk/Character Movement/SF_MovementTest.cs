 using UnityEngine;

public class SF_MovementTest : MonoBehaviour
{
   public SF_CharacterMovement characterTransform;

    float speedMovement = 100.0f;
    float rotationSpeed = 1050.0f;
    float horizontalInput;
    float verticalInput;

    void Start()
    {
        characterTransform = GetComponent<SF_CharacterMovement>();


        // characterTransform.SetPosition(new Vector3(0, 15, 0));
        //characterTransform.SetPosition(new Vector3(-11, 0, -112));
       // characterTransform.setScale(new Vector3(1, 1, 1));     
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        characterTransform.keyboardRotation(horizontalInput, verticalInput, rotationSpeed);

        if (Input.GetKey(KeyCode.W))
        {
            //  characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);

            characterTransform.moveForward(speedMovement);

        }
        else if (Input.GetKey(KeyCode.S))

        {
            //characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);
             characterTransform.moveBackwards(speedMovement);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // characterTransform.JustMove(horizontalInput, verticalInput, speedMovement);
            characterTransform.turnRight(rotationSpeed);
            characterTransform.moveRight(speedMovement);
        }
        else if (Input.GetKey(KeyCode.A))
        {
           characterTransform.turnLeft(rotationSpeed);
            characterTransform.moveLeft(speedMovement);
        }

    }

}

