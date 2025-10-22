using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SF_CharacterMovement : MonoBehaviour
{
    
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
    public void turnLeft(float rotationSpeed)
    {
        Quaternion toRotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

    }
    public void turnRight(float rotationSpeed)
    {
        Quaternion toRotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

    }
    public void turnToRandomDirection(float rotationSpeed)
    {
        float randomY = Random.Range(-360, 360);
        transform.Rotate(0, randomY, 0);

    }

}
