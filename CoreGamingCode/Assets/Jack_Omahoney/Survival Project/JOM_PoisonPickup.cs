using UnityEngine;

public class JOM_PoisonPickup : MonoBehaviour
{
    public float damagePerSecond = 5f;
    public float duration = 3f;

    private void OnTriggerEnter(Collider other)
    {
        JOM_PlayerHealth health = other.GetComponent<JOM_PlayerHealth>();
        if (health != null)
        {
            health.ApplyTimedEffectUsingTimer(-damagePerSecond, duration);
            Destroy(gameObject); // pickup disappears
        }
    }
}
