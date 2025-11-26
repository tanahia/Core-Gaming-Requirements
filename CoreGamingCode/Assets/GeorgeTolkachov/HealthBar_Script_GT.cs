using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class HealthBar_Script_GT : MonoBehaviour
{   
    private float health = 700f;
    private float targetX = 7f;
    private float speed = 10f;
    private float damage = 1.4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;
        scale.x = Mathf.Lerp(scale.x, targetX, Time.deltaTime * speed);
        transform.localScale = scale;


        if (Input.GetKeyDown(KeyCode.Space)) {
            if (health > 0)
            {
                scale.x = Mathf.Lerp(scale.x, targetX -= damage, Time.deltaTime * speed);
                transform.localScale = scale;
                health -= (damage * 100f);
            }
            else { 
                targetX = 0f;
            }

        }

    }
}
