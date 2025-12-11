using UnityEngine;



public class physicsMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public Camera cam;


    public void forwardMovement(float speed)
    {
        Vector3 forwardDir = cam.transform.forward;

        forwardDir.y = 0f;       
        forwardDir.Normalize();   

        rigid.AddForce(forwardDir * speed, ForceMode.Force);
    }

    public void backwardMovement(float speed)
    {
        Vector3 backDir = -cam.transform.forward;

        backDir.y = 0f;
        backDir.Normalize();

        rigid.AddForce(backDir * speed, ForceMode.Force);
    }

    public void rightMovement(float speed)
    {
        Vector3 rightDir = cam.transform.right;

        rightDir.y = 0f;
        rightDir.Normalize();

        rigid.AddForce(rightDir * speed, ForceMode.Force);
    }

    public void leftMovement(float speed)
    {
        Vector3 leftDir = -cam.transform.right;

        leftDir.y = 0f;
        leftDir.Normalize();

        rigid.AddForce(leftDir * speed, ForceMode.Force);
    }
}
