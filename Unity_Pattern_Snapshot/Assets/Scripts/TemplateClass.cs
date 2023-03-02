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
    private float _yAxis, _xAxis, _speed = 10f;
    private string _horizontal = "Horizontal";
    private string _vertical = "Vertical";

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
        _xAxis = Input.GetAxis(_horizontal);
        _yAxis = Input.GetAxis(_vertical);
        transform.Translate(_xAxis * _speed * Time.deltaTime,
                            _yAxis * _speed * Time.deltaTime, 0);
    }
}
