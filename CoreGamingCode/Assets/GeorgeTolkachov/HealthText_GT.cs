using UnityEngine;
using TMPro;

public class HealthText_GT : MonoBehaviour
{
    public TMP_Text text;
    public float speed = 2f;         // Speed of the shine
    public float minDilate = -0.2f;  // Minimum dilate
    public float maxDilate = 0.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float t = (Mathf.Sin(Time.time * speed) + 1f) / 2f; // 0 → 1
        float dilate = Mathf.Lerp(minDilate, maxDilate, t);

        // Apply only to this text
        text.fontMaterial.SetFloat("_FaceDilate", dilate);
    }
}
