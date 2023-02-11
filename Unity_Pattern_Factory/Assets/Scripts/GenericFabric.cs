using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFabric<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected T _prefab;
    [SerializeField] private Transform _pointToSpawn;
    private int n = 0;

    public T GetNewInstance()
    {
        Vector2 pos = new Vector2(_pointToSpawn.position.x, _prefab.transform.position.y + (n++));
        if (n > 5) n = 0;
        return Instantiate(_prefab, pos, Quaternion.identity);
    }
}
