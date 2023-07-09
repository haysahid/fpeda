using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using TMPro;

public class DialogueController : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue;
    private int index;

    public string speaker;
    public TextMeshProUGUI nameText;

    public GameObject contButton;
    public float wordSpeed;

    CutsceneTransition cutsceneTransition = new CutsceneTransition();

    private void Start()
    {
        nameText.text = speaker;
        dialogueText.text = "";

        dialoguePanel.SetActive(true);
        StartCoroutine(Typing());
    }

    private void Update()
    {
        if (dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        contButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
            cutsceneTransition.changeScene(4, false);
        }
    }

}
