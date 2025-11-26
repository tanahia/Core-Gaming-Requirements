using UnityEngine;

public class TestScript : MonoBehaviour
{
    private SF_CharacterMovement movement;
    public float movementSpeed = 50f;

    void Start()
    {
        movement = GetComponent<SF_CharacterMovement>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            movement.moveForward(movementSpeed);

        if (Input.GetKey(KeyCode.S))
            movement.moveBackwards(movementSpeed);

        if (Input.GetKey(KeyCode.D))
            movement.moveRight(movementSpeed);

        if (Input.GetKey(KeyCode.A))
            movement.moveLeft(movementSpeed);

      
        float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
        movement.keyboardRotation(horizontal, vertical, 200f);
    }
}
