using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Menu : MonoBehaviour
{
    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
        Time.timeScale = 1.0f;
    }
    public void ExitTheGame()
    {
        Application.Quit();
    }
}
