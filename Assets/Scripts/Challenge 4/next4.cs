using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class next4 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject nextChallenge;
    public GameObject continueButton;



    public void Start()
    {
        nextChallenge.SetActive(false);
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
            nextChallenge.SetActive(true);
            continueButton.SetActive(false);

        }
    }

    public void nextProblem()
    {
        SceneManager.LoadScene("Challenge5");
    }


}

