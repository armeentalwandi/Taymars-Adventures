using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class storiesorresources : MonoBehaviour
{
    // Start is called before the first frame update
    
   public void stories()
    {
        SceneManager.LoadScene("stories");
    }

    public void resources()
    {
        SceneManager.LoadScene("resources");
    }




    }

