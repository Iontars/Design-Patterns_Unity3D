using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour, ISingleFireing, ITripleFireing
{
    enum SetBulletTest
    {
        Simple, Metal
    }

    private GameObject _bulletGo;
    private Bullet _bullet;
    [SerializeField]private AmmoStorage _ammoStorage;
    [SerializeField]private Transform _bulletSpawnPosition;
    [SerializeField]private SetBulletTest _bulletTest;

    private void Awake()
    {
        _bullet = _ammoStorage.GetBullet();
    }

    private void OnEnable()
    {
        Buttons.LoadSimpleAmmo_e += SetSimple;
        Buttons.LoadMetalAmmo_e += SetMetal;
    }

    private void OnDisable()
    {
        Buttons.LoadSimpleAmmo_e -= SetSimple;
        Buttons.LoadMetalAmmo_e -= SetMetal;
    }

    private void SetSimple()
    {
        _bullet = _ammoStorage.GetBullet();
    }
    
    private void SetMetal()
    {
        _bullet = _ammoStorage.GetBulletPro();
    }
    

    private void Fire()
    {
        _bulletGo = _bullet.gameObject;
        if (!_bulletGo.IsUnityNull())
        {
            TripleShooting();
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    public void SingleShooting()
    {
        Instantiate(_bulletGo, _bulletSpawnPosition.transform.position, Quaternion.identity);
    }

    public void TripleShooting()
    {
        var firstBulletPosition = _bulletSpawnPosition.transform.position;
        Vector2 secondBulletPosition = new Vector2(firstBulletPosition.x - 1, firstBulletPosition.y);
        Vector2 thirdBulletPosition = new Vector2(firstBulletPosition.x + 1, firstBulletPosition.y);
        Instantiate(_bulletGo, firstBulletPosition, Quaternion.identity);
        Instantiate(_bulletGo, secondBulletPosition, Quaternion.identity);
        Instantiate(_bulletGo, thirdBulletPosition, Quaternion.identity);
    }
}
