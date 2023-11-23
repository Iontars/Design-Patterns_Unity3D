using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public static event Action LoadSimpleAmmo_e;
    public static event Action LoadMetalAmmo_e;
    
    void Start()
    {
        
    }

    public void LoadSimpleAmmo()
    {
        LoadSimpleAmmo_e?.Invoke();
    }
    
    public void LoadMetalAmmo()
    {
        LoadMetalAmmo_e?.Invoke();

    }
}
