using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _panel;
    [SerializeField]
    LockedMouse lockedMouse;
    [SerializeField]
    CharacterMouseMove characterMouse;

    private void Start()
    {
       
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0.0f;
            PauseMenuActive();
        }
    }

    public void PanelActiveTrue(int i)
    {
        characterMouse.GetComponent<CharacterMouseMove>().enabled = false;
        Time.timeScale = 0.0f;
        lockedMouse.CursorVisibleTrue();
        _panel[i].SetActive(true);
    }
    public void PanelActiveFalse(int i)
    {
        characterMouse.GetComponent<CharacterMouseMove>().enabled = true;
        Time.timeScale = 1.0f;
        lockedMouse.CursorVisibleFalse();
        _panel[i].SetActive(false);
    }

    void PauseMenuActive()
    {
        characterMouse.GetComponent<CharacterMouseMove>().enabled = false;
        Time.timeScale = 0.0f;
        lockedMouse.CursorVisibleTrue();
        PanelActiveTrue(0);
    }
    public void ExitPauseMenu()
    {
        characterMouse.GetComponent<CharacterMouseMove>().enabled = true;
        Time.timeScale = 1.0f;
        lockedMouse.CursorVisibleFalse();
        PanelActiveFalse(0);
    }
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
