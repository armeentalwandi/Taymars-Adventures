﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Next2 : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject nextButton;


    public void Start()
    {
        nextButton.SetActive(false);
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
            nextButton.SetActive(true);
        }
    }


    public void next()
    {
        SceneManager.LoadScene("Challenge3");
    }
}
