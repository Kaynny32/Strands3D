using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedMouse : MonoBehaviour
{
    public void CursorVisibleFalse()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void CursorVisibleTrue()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
