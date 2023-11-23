using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullMetalBullet : Bullet
{
    protected override float Damage { get; set; }
    protected override float Speed { get; set; }
    protected override float Mass { get; set; }

    private void Awake()
    {
        Speed = 10;
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

