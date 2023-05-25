using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public void DestroyItem()
    {
        GameManager.instance._quantity++;
        Destroy(gameObject);
    }
}
