using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void ClickStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ClickRules()
    {
        SceneManager.LoadScene("Rules");
    }

    public void ClickMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ClickExit()
    {
        Application.Quit();
    }
}
