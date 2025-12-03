using UnityEngine;

public class SF_MenuScript : MonoBehaviour
{
    public Transform buttonTransformClone;
    public Transform canvasTransform;
    public Sprite playbuttonSprite;
    public Sprite QuitbuttonSprite;

    ButtonControlScript playButton, quitButton;
    void Start()
    {
        Transform newButton = Instantiate(buttonTransformClone, canvasTransform);
        playButton = newButton.GetComponent<ButtonControlScript>();
        playButton.Initilise();
        playButton.SetButtonText("Play");
        playButton.SetPosition(new Vector2(0, 50));
      //  playButton.SetColors(Color.white, Color.gray, Color.white, Color.black);
        playButton.SetButtonSize(150, 50);
        playButton.SetButtonImage(playbuttonSprite);
        playButton.SetButtonAction(action);

        newButton = Instantiate(buttonTransformClone, canvasTransform);
        quitButton = newButton.GetComponent<ButtonControlScript>();
        quitButton.Initilise();
        quitButton.SetButtonText("Quit");
        quitButton.SetPosition(new Vector2(0, -50));
      //  playButton.SetColors(Color.white, Color.gray, Color.white, Color.black);
        quitButton.SetButtonSize(150, 50);
        quitButton.SetButtonImage(QuitbuttonSprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void action()
    {
        print("Button Pressed");
    }
}
