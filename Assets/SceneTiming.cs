using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTiming : MonoBehaviour
{
    CutsceneTransition cutsceneTransition = new CutsceneTransition();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToControlRoom());
    }

    IEnumerator GoToControlRoom()
    {
        yield return new WaitForSeconds(5);
        cutsceneTransition.changeScene(10, false);
    }
}
