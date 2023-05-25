using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    [SerializeField]
    GameObject go;

    bool _isActive = false;
    public void AnimDoor(float anim)
    {
        go.transform.DOLocalRotate(new Vector3(0f, 0f, anim), 2.5f);
    }
    public void MoveDoor()
    {        
        if (_isActive == false)
        {            
            go.transform.DOLocalRotate(new Vector3(0f, 0f, 0), 2.5f);
            _isActive = true;
            Debug.Log(_isActive);
        }
        else
        {            
            go.transform.DOLocalRotate(new Vector3(0f, 0f, -90), 2.5f);
            _isActive = false;
            Debug.Log(_isActive);
        }
    }
}
