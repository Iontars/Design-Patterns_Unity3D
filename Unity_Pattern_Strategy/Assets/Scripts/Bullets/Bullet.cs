using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour, IFireing
{
    public float Damage { get;  set; }
    public float Speed { get;  set; }
    public float Mass { get;  set; }
    
    void Start()
    {
        
    }

    public virtual void DestroyBullet()
    {
    }

    

    protected virtual void OnMove()
    {
        
    }

    private void FixedUpdate()
    {
        OnMove();
    }
}
