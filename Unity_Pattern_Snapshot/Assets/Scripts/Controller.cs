#region Using
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using TMPro;
#endregion

/// <summary> Descriptions </summary>
public class Controller : MonoBehaviour
{
    private TemplateClass templateClass;
    private SnapShot snapShot;
    private readonly Stack<SnapShot> _snapStorage = new(); 

    void Awake()
    {
        templateClass = FindObjectOfType(typeof(TemplateClass)) as TemplateClass;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            templateClass.GetCurrentPosition();
            _snapStorage.Push(templateClass.GetSnapShot());
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            print(_snapStorage.Count);
            templateClass.transform.position = _snapStorage.Pop().currentPosition;
        }
    }
}
