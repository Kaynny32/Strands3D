using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AnimButton : MonoBehaviour
{
    [SerializeField]
    List<GameObject> gameObjects = new List<GameObject>();
    private void Start()
    {
        Anim();
    }

    void Anim()
    {        
        for (int i = 0; i < gameObjects.Count; i++)
        {
            gameObjects[i].GetComponent<Button>().interactable = false;
            gameObjects[i].transform.DOMoveX(150f, 3f);
        }
        Invoke("ButtonActive", 3f);
    }
    void ButtonActive()
    {
        for (int i = 0; i < gameObjects.Count; i++)
        {
            gameObjects[i].GetComponent<Button>().interactable = true;
        }
    }
}
