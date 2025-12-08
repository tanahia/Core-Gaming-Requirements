using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    private physicsMovement movement;
    float movementSpeed = 20f;
    public Rigidbody rigid;
    public bool isGrounded = false;

    void Start()
    {
        movement = GetComponent<physicsMovement>();
    }

    void Update()
    {


        if (isGrounded == true) { 


        if (Input.GetKey(KeyCode.W))
            movement.forwardMovement(movementSpeed);

        if (Input.GetKey(KeyCode.S))
            movement.backwardMovement(movementSpeed);

        if (Input.GetKey(KeyCode.D))
            movement.rightMovement(movementSpeed);

        if (Input.GetKey(KeyCode.A))
            movement.leftMovement(movementSpeed);
    }
       // if (h)
        
    }
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
