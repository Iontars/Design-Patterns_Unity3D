using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    enum SetBulletTest
    {
        Simple, Metall
    }

    [SerializeField]private AmmoStorage _ammoStorage;
    private GameObject _bulletGo;
    private Bullet _bullet;
    [SerializeField]private Transform _bulletSpawnPosition;
    [SerializeField]private SetBulletTest _bulletTest;

    private void Awake()
    {
        if (_bulletTest.Equals(SetBulletTest.Simple))
        {
            _bullet = _ammoStorage.GetBullet();
        }
        if (_bulletTest.Equals(SetBulletTest.Metall))
        {
            _bullet = _ammoStorage.GetBulletPro();
        }
    }

    private void Fire()
    {
        _bulletGo = _bullet.gameObject;
        if (_bulletGo != null)
        {
            Instantiate(_bulletGo, _bulletSpawnPosition.transform.position, Quaternion.identity);
        }
        
        print(_bulletGo);
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

}
