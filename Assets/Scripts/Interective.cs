using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interective : MonoBehaviour
{
    [SerializeField]
    Camera _fpsCamera;
    [SerializeField]
    float _maxDistanceRay;

    Ray _ray;
    RaycastHit _hit;    
    void Update()
    {       
        Ray();
        DrawRay();
        ItemInteract(); 
    }

    void Ray()
    {
        _ray = _fpsCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    void DrawRay()
    {
        if (Physics.Raycast(_ray, out _hit, _maxDistanceRay))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.blue);
        }
        if (_hit.transform == null)
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.red);
        }
    }

    void ItemInteract()
    {
        if (_hit.transform != null && _hit.transform.GetComponent<Item>())
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.green);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                _hit.transform.GetComponent<Item>().DestroyItem();
            }
        }
        if (_hit.transform != null && _hit.transform.GetComponent<Door>())
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.green);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                _hit.transform.GetComponent<Door>().MoveDoor();
            }
        }

    }
}
