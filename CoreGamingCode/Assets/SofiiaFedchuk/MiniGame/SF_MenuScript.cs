using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SF_MenuScript : MonoBehaviour
{
    public Transform buttonTransformClone;
    public Transform canvasTransform;
    public Sprite playbuttonSprite;
    public Animator transition1;
 
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
      //  playButton.SetColors(Color.white, Color.gray, Color.white, Color.black);
        playButton.SetButtonSize(150, 50);
        playButton.SetButtonImage(playbuttonSprite);
        playButton.SetButtonAction(LoadNextLevel);
      // playButton.SetColors(new Color(1, 0, 0, 0.5f), Color.gray, Color.green, Color.black);

    }

    // Update is called once per frame
    void LateUpdate()
    {
       
        if(isButtonFading)
        {
            print(buttonOpacity);
        }
       
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

        transition1.SetTrigger("End");
        //transition2.SetTrigger("ButtonEnd");
       
        yield return new WaitForSeconds(transitionTime);
         SceneManager.LoadSceneAsync(name);
     }
}
