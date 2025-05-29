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
    public void Wire_ja_button()
    {
        SceneManager.LoadScene("Scene2");

    }
    public void Wire_Nein_button()
    {
        SceneManager.LoadScene("Scene2");

    }public void Wire_3_button()
    {
        SceneManager.LoadScene("3_wire");

    }public void Wire_4_button()
    {
        SceneManager.LoadScene("4_wire");

    }public void Wire_5_button()
    {
        SceneManager.LoadScene("5_wire");

    }public void Wire_6_button()
    {
        SceneManager.LoadScene("6_wire");

    }


}
