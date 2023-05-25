using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoherTriger : MonoBehaviour
{
    [SerializeField]
    Door door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Interective>())
        {
            if (GameManager.instance._quantity == 3)
            {
                door.AnimDoor(-90);
            }
        }
    }
}
