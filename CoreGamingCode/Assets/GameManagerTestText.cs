using UnityEngine;

public class GameManagerTestText : MonoBehaviour
{

    public Transform textTransformClone;

    TextControl score, message, health, timerMessage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Transform newText =  Instantiate(textTransformClone);
        score = newText.GetComponent<TextControl>();
      
        score.gameObject.name = "Score Text GO";
        newText = Instantiate(textTransformClone);
        message = newText.GetComponent<TextControl>();
        message.SetText("Warning");
        message.gameObject.name = "Warning Text GO";
        message.SetColor(Color.red);
        message.Blink(0, 1, 3);
        message.SetPosition(new Vector3(5, 0, 10));
        newText = Instantiate(textTransformClone);
        health = newText.GetComponent<TextControl>();
        health.gameObject.name = "Health Text GO";
        health.SetText("Health : 100%");
        health.SetColor(Color.yellow);
        health.SetFont(5);
        health.SetFontSize(32);
        health.SetPosition(new Vector3(-15, 10, 10));
        newText = Instantiate(textTransformClone);
        timerMessage = newText.GetComponent<TextControl>();


        score.SetText("Score 0");
        score.SetColor(Color.green);
        score.SetPosition(new Vector3(15, 5, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
