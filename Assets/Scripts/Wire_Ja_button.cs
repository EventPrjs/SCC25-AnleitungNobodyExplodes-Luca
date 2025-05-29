using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Start_button : MonoBehaviour
{
   public void Startbutton()
    {
        SceneManager.LoadScene("Scene1");

    }
   
}
