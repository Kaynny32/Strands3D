using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject _prefabs;
    [SerializeField]
    List<GameObject> _spawnpoints;

    List<GameObject> _prefabsClone = new List<GameObject>();
    int index;
    public void Spawn()
    {        
        for (int i =0; i<3; i++)
        {
            GameObject go = Instantiate(_prefabs, _spawnpoints[Random.Range(0,22)].transform);
            _prefabsClone.Add(go);
        }
    }
}
