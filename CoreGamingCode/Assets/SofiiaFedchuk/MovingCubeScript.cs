using UnityEngine;

public class MovingCubeScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
       	transform.position += new Vector3(0,1,0);
    }
}
