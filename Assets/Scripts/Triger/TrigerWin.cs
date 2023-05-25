using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerWin : MonoBehaviour
{
    [SerializeField]
    UI_Manager manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Interective>())
        {
            manager.PanelActiveTrue(1);
        }
    }
}
