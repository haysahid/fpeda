using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ChangeAfter2SecondsCoroutine());
    }

    IEnumerator ChangeAfter2SecondsCoroutine()
    {
        yield return new WaitForSeconds(5);    
        SceneManager.LoadScene("CutscenePrologue");
    }

}
