using UnityEngine;

public class MS_PlaneScript : MonoBehaviour
{
    // private float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += speed * transform.forward * Time.deltaTime;

        transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
    }
}
