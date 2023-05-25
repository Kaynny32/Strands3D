using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMouseMove : MonoBehaviour
{
    [SerializeField]
    Camera _playerCamera;
    [SerializeField]
    float sensivity;
    [SerializeField]
    float _smoothTime;
    [SerializeField]
    GameObject _playerGameObject;

    float x_Rot;
    float y_Rot;

    float x_RotCurrent;
    float y_RotCurrent;
    float x_currentVelosity;
    float y_currentVelosity;

    private void Update()
    {
        MouseMove();
    }

    void MouseMove()
    {
        x_Rot += Input.GetAxis("Mouse X") * sensivity;
        y_Rot += Input.GetAxis("Mouse Y") * sensivity;
        y_Rot = Mathf.Clamp(y_Rot, -70f, 70f);

        x_RotCurrent = Mathf.SmoothDamp(x_RotCurrent, x_Rot, ref x_currentVelosity, _smoothTime);
        y_RotCurrent = Mathf.SmoothDamp(y_RotCurrent, y_Rot, ref y_currentVelosity, _smoothTime);

        _playerCamera.transform.rotation = Quaternion.Euler(-y_RotCurrent, x_RotCurrent, 0f);
        _playerGameObject.transform.rotation = Quaternion.Euler(0f, x_RotCurrent, 0f);
    }
}
