using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour, IFireing
{
    protected abstract float Damage { get;  set; }
    protected abstract float Speed { get;  set; }
    protected abstract float Mass { get;  set; }

    protected Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public virtual void DestroyBullet()
    {
    }

    

    protected virtual void OnMove()
    {
        rb.velocity = Vector2.up * Speed;
    }

    private void FixedUpdate()
    {
        OnMove();
    }
}
