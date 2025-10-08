using UnityEngine;
using UnityEngine.UIElements;

public class SF_MovementTest : MonoBehaviour
{
   public SF_CharacterMovement characterTransform;
    void Start()
    {
        characterTransform = GetComponent<SF_CharacterMovement>();

        characterTransform.SetPosition(new Vector3(50, 70, 10));
       /* Transform charPosition = GetComponent<Transform>();
        if (charPosition != null)
        {
            charPosition.transform.position = new Vector3(10,20,10);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
