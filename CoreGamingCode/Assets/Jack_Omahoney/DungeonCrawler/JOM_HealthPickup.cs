using UnityEngine;

public class JOM_HealthPickup : MonoBehaviour
{
    public float healPerSecond = 5f;
    public float duration = 3f;

    private void OnTriggerEnter(Collider other)
    {
        JOM_PlayerHealth health = other.GetComponent<JOM_PlayerHealth>();
        if (health != null)
        {
            health.ApplyTimedEffectUsingTimer(healPerSecond, duration);
            Destroy(gameObject); // pickup disappears
        }
    }
}
