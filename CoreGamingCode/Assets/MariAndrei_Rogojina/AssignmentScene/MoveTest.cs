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

        
        if (Input.GetKey(KeyCode.W))
            { walk.moveForward(5); }

        if (Input.GetKey(KeyCode.A))
            { walk.moveLeft(5); }

        if (Input.GetKey(KeyCode.S))
        { walk.moveBackwards(5); }

        if(Input.GetKey(KeyCode.D))
        { walk.moveRight(5); };
    }
}