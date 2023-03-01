#region Using
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using TMPro;
#endregion

public class TemplateClass : MonoBehaviour
{
    private Vector3 _currentPosition;
    private readonly Stack<SnapShot> _snapStorage = new(); 

    private void Start()
    {
        GetCurrentPosition();
    }
    
    public void GetCurrentPosition()
    {
        _currentPosition = transform.position;
    }

    public SnapShot GetSnapShot()
    {
        return new SnapShot(_currentPosition);
    }


    private void Update()
    {
        
    }
}
