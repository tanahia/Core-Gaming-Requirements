using UnityEngine;

public class SF_PlayerController : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;

    [SerializeField] Rigidbody rb;


    Vector3 movement;


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
            mouseMovement(x, z, speed);
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



    public void mouseMovement(float x, float z, float speed)
    {



        movement = transform.right * x + transform.forward * z;
        rb.AddForce(movement.normalized * speed);
    }
    public void keyboardRotation(float x, float z, float rotationSpeed)
    {

        Vector3 dir = (transform.right * x + transform.forward * z).normalized;

        // if there's input, rotate toward it
        if (dir != Vector3.zero)
        {
            Quaternion target = Quaternion.LookRotation(dir, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                target,
               rotationSpeed * Time.fixedDeltaTime
            );
        }
        /*  Vector3 moveDirection = new Vector3(x, 0, z);
          if (moveDirection.sqrMagnitude > 0.01f)
          {
              Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
              transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, speed * Time.fixedDeltaTime);

          }*/
    }
    public void keyboardMovement(float x, float z, float speed)
    {

        movement = transform.right * x + transform.forward * z;
        // movement=new Vector3(x, 0, z);
        rb.AddForce(movement.normalized * speed);
    }
}
