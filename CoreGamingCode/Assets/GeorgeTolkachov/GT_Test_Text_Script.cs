using UnityEngine;
using TMPro;
using System.Collections; // Import TMP namespace

public class GT_Test_Text_Script : MonoBehaviour
{
    private int i = 0;  // To keep track of the clone number
    public Transform textGOCloneTemplate;  // The prefab to clone (TextMeshPro object)
    public float fadeDuration = 2f;        // Duration for fading (seconds)
    public float verticalOffset = 50f;     // Space between cloned text objects in the Y-axis

    void Update()
    {
        // When space key is pressed, clone the text and start fading it
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate the text prefab (cloning)
            Transform temp = Instantiate(textGOCloneTemplate);

            // Set the text content
            TMP_Text myTempText = temp.GetComponent<TMP_Text>();
            myTempText.SetText("Clone No. " + i.ToString()); // Set the current value of i in the text
            i++;  // Increment i after setting the text

            // Position the cloned text so it doesn't overlap (stack vertically)
            Vector3 newPosition = temp.position;
            newPosition.y += i * verticalOffset;  // Increase the Y position for each clone
            temp.position = newPosition;

            // Set initial alpha to 0 (fully transparent)
            Color initialColor = myTempText.color;
            myTempText.color = new Color(initialColor.r, initialColor.g, initialColor.b, 0f);

            // Start the fade-in process by modifying the TMP_Text color
            StartCoroutine(FadeText(myTempText, 1f));  // Fade to alpha = 1 (fully visible)
        }
    }

    // I dont know how it works
    // just a bunch of dirty barnacles vomitted by chatgpt


    // Coroutine to fade the TMP_Text alpha over time
    private IEnumerator FadeText(TMP_Text textMeshPro, float targetAlpha)
    {
        Color currentColor = textMeshPro.color;  // Get current color of the TMP_Text
        float currentAlpha = currentColor.a;     // Get current alpha value
        float timeElapsed = 0f;

        // Gradually change alpha from current to target over fadeDuration seconds
        while (timeElapsed < fadeDuration)
        {
            timeElapsed += Time.deltaTime;  // Increase time passed since the coroutine started
            float newAlpha = Mathf.Lerp(currentAlpha, targetAlpha, timeElapsed / fadeDuration);
            textMeshPro.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);  // Set new alpha value
            yield return null;  // Wait until the next frame
        }

        // Ensure the final alpha value is set to the target alpha
        textMeshPro.color = new Color(currentColor.r, currentColor.g, currentColor.b, targetAlpha);
    }
}