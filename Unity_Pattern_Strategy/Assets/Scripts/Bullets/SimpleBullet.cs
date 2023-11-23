using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    
    protected override float Damage { get; set; }
    protected override float Speed { get; set; }
    protected override float Mass { get; set; }

    private void Awake()
    {
        Speed = 100;
    }
    
    protected override void OnMove()
    {
        rb.velocity = Vector2.up * this.Speed;
    }

    private void Update()
    {
        OnMove();
    }
}
