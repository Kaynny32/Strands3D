using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTriger : MonoBehaviour
{
    [SerializeField]
    GameObject _light;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Interective>())
        {
            AnimLight();
        }
    }
    void AnimLight()
    {
        _light.GetComponent<Light>().DOIntensity(0f, 0.2f).SetLoops(-1, LoopType.Restart);       
    }
}
