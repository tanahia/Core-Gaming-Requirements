 using UnityEngine;

public class SF_MovementTest : MonoBehaviour
{

    /*This script allows you to move the player object through keyboard input(wasd) and rotates the player object towards movement direction.
     * To make this script work ypu need to attach rigibody component and this script to the player object.
     * If you see that the player object moves on its own after releasing the key you need to increase linear damping value of the rigibody component.
     */
    /*You can change values of speed and Rigidbody in Unity environment. */
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;

    Vector3 movement;//variable to store movement direction


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.W))
        {
            keyboardMovement(x, z, speed);
            keyboardRotation(x, z, speed);


        }
        else if (Input.GetKey(KeyCode.S))

        {
            keyboardMovement(x, z, speed);
            keyboardRotation(x, z, speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            keyboardMovement(x, z, speed);
            keyboardRotation(x, z, speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            keyboardMovement(x, z, speed);
            keyboardRotation(x, z, speed);
        }
    }

    /*Method that performs the player object rotation through keyboard*/
    public void keyboardRotation(float x, float z, float speed)
    {

        movement = new Vector3(x, 0, z);
        if (movement.sqrMagnitude > 0.01f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, speed * Time.fixedDeltaTime);

        }
    }
    /*Method that performs the player object movement through keyboard*/
    public void keyboardMovement(float x, float z, float speed)
    {
        movement = new Vector3(x, 0, z);
        rb.AddForce(movement.normalized * speed);
    }

}

