using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    private GameObject _gameObject;

    private void Awake()
    {
        _gameObject = gameObject;
    }
    

    protected override void OnMove()
    {
        
    }

    private void Update()
    {
        OnMove();
    }
}
