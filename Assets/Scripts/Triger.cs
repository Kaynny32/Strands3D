using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    [SerializeField]
    Door _door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Interective>())
        {
            _door.AnimDoor();
            gameObject.SetActive(false);
        }
    }
}
