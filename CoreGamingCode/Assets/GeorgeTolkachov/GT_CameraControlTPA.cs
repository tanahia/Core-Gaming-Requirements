using UnityEngine;

public class GT_CameraControlTPA : MonoBehaviour
{

    public Transform Player;

    float distanceBehind = 4f, distanceUp = 2f;


    float theta = 0f, phi = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        theta += 0.5f;
        transform.position = Player.transform.position - distanceBehind*Player.transform.forward + distanceUp * Vector3.up;
        transform.RotateAround(Player.position, Vector3.right, theta);
        transform.LookAt(Player);


    }
}
