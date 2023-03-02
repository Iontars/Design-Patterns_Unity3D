#region Using
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using TMPro;
#endregion
/// <summary> Снимок </summary>
public class SnapShot : MonoBehaviour
{
    public Vector3 currentPosition;
    private TemplateClass _templateClass;

    public SnapShot(TemplateClass templateClass, Vector3 inputPosition)
    {
        _templateClass = templateClass;
        currentPosition = inputPosition;
    }
    
    void Start()
    {
        //_templateClass = FindObjectOfType(typeof(TemplateClass)) as TemplateClass;

    }
    
    void Update()
    {
        
    }
}
