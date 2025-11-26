using UnityEngine;



public class physicsMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public float forceAmount = 150f;

    public void forwardMovement(float speed)
    {
        rigid.AddForce(Vector3.forward * speed, ForceMode.Force);

    }
    public void backwardMovement(float speed)
    {
        rigid.AddForce(Vector3.back * speed, ForceMode.Force);

    }
    public void rightMovement(float speed)
    {
        rigid.AddForce(Vector3.right * speed, ForceMode.Force);
    }
    public void leftMovement(float speed)
    {
        rigid.AddForce(Vector3.left * speed, ForceMode.Force);
    }
}
