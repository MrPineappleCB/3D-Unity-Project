using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene(1);
        //Debug.Log("Start Pressed");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
