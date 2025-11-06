using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public Transform buttonTransformClone;
    public Transform canvasTransform;
    public Sprite playbuttonSprite;
    public Sprite QuitbuttonSprite;

    ButtonControlScript playButton, quitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Transform newButton =  Instantiate(buttonTransformClone,canvasTransform);
       playButton = newButton.GetComponent<ButtonControlScript>();
       playButton.Initilise();
       playButton.SetButtonText("Play");
       playButton.SetPosition(new Vector2(0,0));
       playButton.SetColors(Color.white, Color.gray, Color.green, Color.black);
       playButton.SetButtonSize(150,50);
       playButton.SetButtonImage(playbuttonSprite);
       playButton.SetButtonAction(action);

       newButton = Instantiate(buttonTransformClone,canvasTransform);
       quitButton = newButton.GetComponent<ButtonControlScript>();
       quitButton.Initilise();
       quitButton.SetButtonText("Quit");
       quitButton.SetPosition(new Vector2(0,-50));
       quitButton.SetColors(Color.white, Color.gray, Color.red, Color.black);
       quitButton.SetButtonSize(150,50);
       quitButton.SetButtonImage(QuitbuttonSprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// This Creates a method that lets the button do something when pressed
    /// </summary>
    public void action()
    {
        print("Button Pressed");
    }
}
