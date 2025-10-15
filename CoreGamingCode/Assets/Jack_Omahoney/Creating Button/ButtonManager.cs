using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public Transform buttonTransformClone;
    //public Transform canvasTransform;

    ButtonControlScript playButton, quitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Transform newButton =  Instantiate(buttonTransformClone);
       playButton = newButton.GetComponent<ButtonControlScript>();
        playButton.Initilise();
         playButton.SetButtonText("Play");
         playButton.SetPosition(new Vector3(0, 50, 0));
         playButton.SetColors(Color.white, Color.gray, Color.green, Color.black);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
