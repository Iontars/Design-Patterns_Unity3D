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
    private TemplateClass _templateClass;
    private SnapShot _snapShot;

    private void Awake()
    {
        _templateClass = FindObjectOfType(typeof(TemplateClass)) as TemplateClass;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Save");
            _templateClass.GetCurrentPosition();
            Storage.SnapStorage.Push(_templateClass.GetSnapShot());
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            print(Storage.SnapStorage.Count);
            _templateClass.transform.position = Storage.SnapStorage.Pop().currentPosition;
        }
    }
}
