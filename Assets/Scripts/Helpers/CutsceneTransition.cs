using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTransition
{

    Scenes scenes = new Scenes();

    public void changeScene(int goToScene, bool isDelay)
    {

        if (!isDelay)
        {
            SceneManager.LoadScene(scenes.sceneList[goToScene]);
        }

        if (isDelay)
        {
            changeSceneWithDelay(goToScene);
        }

    }

    IEnumerator changeSceneWithDelay(int goToScene)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(scenes.sceneList[goToScene]);
    }

}