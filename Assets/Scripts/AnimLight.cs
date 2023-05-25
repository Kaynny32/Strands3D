using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimLight : MonoBehaviour
{
    void Start()
    {
        Light();
    }
    void Light()
    {
        gameObject.GetComponent<Light>().DOIntensity(0f,0.2f).SetLoops(-1, LoopType.Restart);
    }
}
