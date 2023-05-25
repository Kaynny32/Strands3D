using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    LockedMouse lockedMouse;
    [SerializeField]
    Spawner spawner;
    [SerializeField]
    UI_Manager ui_manager;

    [SerializeField]
    TextMeshProUGUI _quantityText;
    [SerializeField]
    TextMeshProUGUI _timerText;
    [SerializeField]
    GameObject _triger;
    [SerializeField]
    GameObject _trigerWin;
    [SerializeField]
    TextMeshProUGUI _winText;

    float timer = 60.0f;

    public int _quantity;
    public static GameManager instance = null;
    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        SateStart();
    }

    void SateStart()
    {
        lockedMouse.CursorVisibleFalse();
        spawner.Spawn();
        _triger.GetComponent<SphereCollider>().enabled = false;
        _trigerWin.GetComponent<BoxCollider>().enabled = false;
        _winText.GetComponent<TextMeshProUGUI>().enabled = false;
    }
    
    private void FixedUpdate()
    {
        GameState();
        CountItems();
    }

    void CountItems()
    {
        _quantityText.text = $"{_quantity}/3";
        if (timer <=15)
        {
            _timerText.color = Color.red;
        }
    }
   

    void GameState()
    {
        if (timer > 0)
        {
            timer -= Time.fixedDeltaTime;
            _timerText.text = timer.ToString();
            if (_quantity == 3)
            {
                Win();
            }
        }
        else
        {
            ui_manager.PanelActiveTrue(2);
        }
    }
    void Win()
    {
        _triger.GetComponent<SphereCollider>().enabled = true;
        _trigerWin.GetComponent<BoxCollider>().enabled = true;
        _quantityText.color = Color.green;
         _winText.GetComponent<TextMeshProUGUI>().enabled = true;
        _winText.color = Color.green;
    }
}
