using UnityEngine;

public class JOM_PoisonPickup : MonoBehaviour
{
    public float damagePerSecond = 10f;

    private void OnTriggerStay(Collider other)
    {
        JOM_PlayerHealth player = other.GetComponent<JOM_PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damagePerSecond * Time.deltaTime);
        }
    }
}
