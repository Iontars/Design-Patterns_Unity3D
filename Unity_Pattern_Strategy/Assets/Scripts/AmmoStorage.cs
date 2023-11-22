using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoStorage : MonoBehaviour
{
    [SerializeField] private SimpleBullet _simpleBullet;
    [SerializeField] private FullMetalBullet _fullMetalBullet;
    void Start()
    {
        
    }

    public Bullet GetBullet(Bullet bullet)
    {
        return bullet;
    }
}
