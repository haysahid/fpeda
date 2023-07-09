using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{

    CutsceneTransition cutsceneTransition = new CutsceneTransition();

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ToOldCity()
    {
        cutsceneTransition.changeScene(0, false);
    }

    public void ToOldDome()
    {
        cutsceneTransition.changeScene(1, false);
    }

    public void ToDesert()
    {
        cutsceneTransition.changeScene(2, false);
    }
}