using System;
using UnityEngine;

public class GT_CameraControlTPA : MonoBehaviour
{

    public Transform Player;

    float distanceBehind = 4f, distanceUp = 2f;


    float theta = 0f, phi = 0f;

    float minCamElevation = -10f, maxCamElevation = 80f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
     
        transform.Rotate(Vector3.up, theta,Space.World);

        Quaternion rot = transform.rotation;
        transform.Rotate(Vector3.right,  phi);
        if (angleNotRight())
            transform.rotation = Quaternion.Slerp(rot, transform.rotation, 0.1f);

        transform.position = Player.transform.position - distanceBehind * transform.forward + distanceUp * transform.up;
        Cursor.visible = false;
        print("theta " + theta);
        print("phi "+ phi);

    }

    private bool angleNotRight()
    {
        return Vector3.Dot(transform.forward, Vector3.forward) < 0.3f;
    }

    public void lateralRotate(float diff) { 
        theta = diff;
    }

    public void verticalRotate(float diff) { 
        phi = diff;

        
    }
}
