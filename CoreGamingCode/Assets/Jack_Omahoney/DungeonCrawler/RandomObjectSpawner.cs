using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject[] objectToSpawn;
    public int numberOfObjects = 15;

    public float rangeX = 10f;
    public float rangeZ = 10f;
    public float fixedY = 0.5f;
    void Start()
    {
        SpawnObjects();
    }

    // Update is called once per frame
    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Pick a random object from the array
            GameObject objToSpawn = objectToSpawn[UnityEngine.Random.Range(0, objectToSpawn.Length)];

            // Pick a random position within the specified area
            Vector3 randomPos = new Vector3(
                UnityEngine.Random.Range(-rangeX, rangeX),
                fixedY,
                UnityEngine.Random.Range(-rangeZ, rangeZ)
            );

            // Instantiate the object at the random position
            Instantiate(objToSpawn, randomPos, Quaternion.identity);
        }
    }
}
