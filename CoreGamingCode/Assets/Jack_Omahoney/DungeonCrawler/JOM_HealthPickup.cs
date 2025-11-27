using UnityEngine;

public class JOM_HealthPickup : MonoBehaviour
{
    public float healPerSecond = 10f;

    private void OnTriggerStay(Collider other)
    {
        JOM_PlayerHealth player = other.GetComponent<JOM_PlayerHealth>();
        if (player != null)
        {
            player.Heal(healPerSecond * Time.deltaTime);
        }
    }
}
