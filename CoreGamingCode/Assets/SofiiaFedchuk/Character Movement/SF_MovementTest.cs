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

        characterTransform.SetPosition(new Vector3(0, 15, 0));
        characterTransform.setScale(new Vector3(5, 5, 5));     
    }

    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        characterTransform.keyboardRotation(horizontalInput, verticalInput, rotationSpeed);
      
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
        else if(Input.GetKey(KeyCode.F))
        {
            characterTransform.turnLeft(rotationSpeed);
        }
     

    }

}

