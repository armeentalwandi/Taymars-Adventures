using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Text3 : MonoBehaviour
{
    
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject choice1;
    public GameObject choice2;

   
    public void Start()
    {
        choice1.SetActive(false);
        choice2.SetActive(false);
   
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
            choice1.SetActive(true);
            choice2.SetActive(true);
          

        }
    }

    public void choose1()
    {
        SceneManager.LoadScene("Wrong3");
    }

    public void choose2()
    {
        SceneManager.LoadScene("Right3");
    }


    

}
