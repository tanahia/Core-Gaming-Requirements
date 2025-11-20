using UnityEngine;

public class MoveTest : MonoBehaviour
{

    SF_CharacterMovement walk;

    void Start()
    {
        walk = gameObject.transform.GetComponent<SF_CharacterMovement>();
    }


    void Update()
    {

        Input.GetKey(KeyCode.W);
        { walk.moveForward(5); }

        Input.GetKey(KeyCode.A);
        { walk.moveLeft(5); }

        Input.GetKey(KeyCode.S);
        { walk.moveBackwards(5); }

        Input.GetKey(KeyCode.D);
        { walk.moveRight(5); }
    }
}