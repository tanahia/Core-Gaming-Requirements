using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    SF_CharacterMovement playerMovement;
    public Transform playerBox;
    public float speed = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform player = Instantiate(playerBox);
        playerMovement = player.GetComponent<SF_CharacterMovement>();
        //playerMovement.SetPosition(new Vector3(10, 10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
