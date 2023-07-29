using UnityEngine;
using System.Collections;

public class EnterRoom : MonoBehaviour
{
    CutsceneTransition cutsceneTransition = new CutsceneTransition();

    // Use this for initialization
    void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
			
	}

    private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("Player"))
        {
            // Loding
            cutsceneTransition.changeScene(11, false);
        }
    }
}

