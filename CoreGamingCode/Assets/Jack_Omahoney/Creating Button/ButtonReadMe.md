Must use button prefab and ButtonControlScript

First you would create a canvas that will hold the button aswell as the event magager and a empty game object like a game manager

Secondly in a new script you will instantiate the button prefab aswell as the canvas 

Call any of the public methods within the ButtonControlScript

SetPostion
SetColors
SetButtonText
SetButtonSize
SetButtonImage
SetButtonAction

In unity you would put your new script onto your empty game object example(GameManager) here you will drag the button prefab onto the button transfom clone
same when you drag the canvas onto the canvas transform you made.

In the case for the Set image what you can do is make something like a (playbuttonsprite) same way as you made the buttontransform clone then inside your game object
you can use any of the images that are already there but if you wanted to add your own image you can make a PNG image for example in paint
import it in through the import new asset under the asset section in unity.
Then to be able to use this image you would go into the inspector of the image and change the Texture Type to Sprite (2D and UI),
Sprite mode change to Single and Mesh Type to Full Rect.

Now you should be able to drag your image onto your (playbuttonsprite) and your image should now show as your button.

Lastly if you would want to use the SetButtonAction method you would call the method then you would make a new method in your script
called action for example that would then contain whatever you wanted your button to do.


Examples of two working buttons can be seen within my own ButtonManager Script.
