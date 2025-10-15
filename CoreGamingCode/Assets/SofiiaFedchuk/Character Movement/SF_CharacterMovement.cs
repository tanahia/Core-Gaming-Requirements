using UnityEngine;

public class SF_CharacterMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPosition(Vector3 position)
    {

        transform.position = position;
    }
    public void setScale(Vector3 scale)
    {
        transform.localScale = scale;
    }
    public void moveForward(float speed)
    {
        transform.position+=Vector3.forward*Time.deltaTime*speed;
        
    }
    public void moveBackwards(float speed)
    {
        transform.position += Vector3.back * Time.deltaTime * speed;

    }
    public void moveRight(float speed)
    {
        transform.position += Vector3.right * Time.deltaTime * speed;
    }
    public void moveLeft(float speed)
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }
    
    public void keyboardRotation(float horizontalInput, float verticalInput, float rotationSpeed)
    {
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();
        if (movementDirection != Vector3.zero)
         {
             Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
             transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
         }
    }
  /*  public void mouseRotation(float rotationX, float rotationY)
        
    {


        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);


    }*/
}
