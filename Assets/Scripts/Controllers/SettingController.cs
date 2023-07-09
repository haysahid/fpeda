using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingController : MonoBehaviour
{

    CutsceneTransition cutsceneTransition = new CutsceneTransition();

    // Start is called before the first frame update
    public void SreenMode() { Screen.fullScreen = !Screen.fullScreen;}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")) { cutsceneTransition.changeScene(0,false);}
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    

}
