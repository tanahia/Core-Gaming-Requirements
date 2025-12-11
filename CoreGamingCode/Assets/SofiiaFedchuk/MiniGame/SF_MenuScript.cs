using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SF_MenuScript : MonoBehaviour
{
    public Transform buttonTransformClone;
    public Transform canvasTransform;
    public Sprite playbuttonSprite;
 
   public float transitionTime;
    bool isButtonFading = false;
    float buttonOpacity = 1f;
    float timer;

    ButtonControlScript playButton;
    void Start()
    {
        Transform newButton = Instantiate(buttonTransformClone, canvasTransform);
        playButton = newButton.GetComponent<ButtonControlScript>();
        playButton.Initilise();
        playButton.SetButtonText("Play");
        playButton.SetPosition(new Vector2(0, 0));
        playButton.SetButtonSize(150, 50);
        playButton.SetButtonImage(playbuttonSprite);
        playButton.SetButtonAction(LoadNextLevel);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
   
    public void LoadNextLevel()
    {
        // SceneManager.LoadScene("MiniGame");
        
        isButtonFading = true;
        timer = transitionTime;
        StartCoroutine(LoadLevel("MiniGame"));
    }
    IEnumerator LoadLevel(string name)
     {
        float timer = 0f;
        while(timer<transitionTime)
        {
            timer += Time.deltaTime;
            buttonOpacity = Mathf.Lerp(1f, 0f, timer / transitionTime);
            canvasTransform.GetComponent<CanvasGroup>().alpha = buttonOpacity;
            yield return null;
        }  
        yield return new WaitForSeconds(transitionTime);
         SceneManager.LoadScene(name);
        print(timer);
     }
}
