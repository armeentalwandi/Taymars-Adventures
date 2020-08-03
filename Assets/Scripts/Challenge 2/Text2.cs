using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Text2 : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject rightButton;
    public GameObject wrongButton;


    public void Start()
    {
        rightButton.SetActive(false);
        wrongButton.SetActive(false);
        StartCoroutine(Type());
    }

    public void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);

        }
    }


    IEnumerator Type()
    {

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }

    }

    public void NextSentence()
    {

        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            rightButton.SetActive(true);
            wrongButton.SetActive(true);
        }
    }


    public void Right()
    {
        SceneManager.LoadScene("Right2");
    }

    public void Wrong()
    {
        SceneManager.LoadScene("Wrong2");
    }
}
