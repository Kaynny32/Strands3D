using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    [SerializeField]
    GameObject go;
    public void AnimDoor(float anim)
    {
        go.transform.DOLocalRotate(new Vector3(0f, 0f, anim), 2.5f);
    }
    public void Open()
    {
        go.transform.DORotate(new Vector3(0f, 0f, -90f), 2.5f);
    }
    public void Close()
    {
        go.transform.DORotate(new Vector3(0f, 0f, 90f), 2.5f);
    }
}
