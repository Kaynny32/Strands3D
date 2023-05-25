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
    

    float timer = 180.0f;

    public int _quantity;
    public static GameManager instance = null;
    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        lockedMouse.CursorVisibleFalse();
        spawner.Spawn();
        _triger.GetComponent<SphereCollider>().enabled = false;
        _trigerWin.GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {
        CountItems();
    }
    
    private void FixedUpdate()
    {
        GameState();
    }

    void CountItems()
    {
        _quantityText.text = $"{_quantity}/3";
    }
   

    void GameState()
    {
        if (timer > 0 )
        {
            timer -= Time.fixedDeltaTime;
            _timerText.text = timer.ToString();
            if (_quantity == 3)
            {
                Win();
               // ui_manager.PanelActiveTrue(1);
            }
        }
        else
        {
            ui_manager.PanelActiveTrue(2);
        }
    }
    void Win()
    {
        if (_quantity == 3)
        {
            _triger.GetComponent<SphereCollider>().enabled = true;
            _trigerWin.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
