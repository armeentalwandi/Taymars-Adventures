using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OpenLink : MonoBehaviour
{

    public void OpenChannel()
    {
        Application.OpenURL("https://blacklivesmatter.com/");
    }

    public void OpenChannel1()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=XoIEH4qzBdE");
    }

    public void OpenChannel2()
    {
        Application.OpenURL("https://blacklivesmatters.carrd.co/");
    }

    public void OpenChannel3()
    {
        Application.OpenURL("https://www.cbc.ca/kidsnews/post/why-has-the-death-of-george-floyd-sparked-protests");
    }

    public void OpenChannel4()
    {
        Application.OpenURL("https://www.nytimes.com/article/breonna-taylor-police.html");
    }

    public void OpenChannel5()
    {
        Application.OpenURL("https://www.nytimes.com/article/who-was-elijah-mcclain.html");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void back()
    {
        SceneManager.LoadScene("Info");
    }

    
}
