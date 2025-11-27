using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    private physicsMovement movement;
    float movementSpeed = 10f;


    void Start()
    {
        movement = GetComponent<physicsMovement>();
    }

    void Update()
    {


        if (Input.GetKey(KeyCode.W))
            movement.forwardMovement(movementSpeed);

        if (Input.GetKey(KeyCode.S))
            movement.backwardMovement(movementSpeed);

        if (Input.GetKey(KeyCode.D))
            movement.rightMovement(movementSpeed);

        if (Input.GetKey(KeyCode.A))
            movement.leftMovement(movementSpeed);
    }
}
