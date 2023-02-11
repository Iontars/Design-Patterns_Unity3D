using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFabric<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _prefab;
    [SerializeField] private Transform _pointToSpawn;
    private int n = 0;

    public T GetNewInstance()
    {
        Vector3 pos = new Vector3(_pointToSpawn.position.x, _prefab.transform.position.y, _pointToSpawn.position.z + n);
        return Instantiate(_prefab, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
