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

    public SnapShot( Vector3 inputPosition)
    {
        currentPosition = inputPosition;
    }
    
    public void CancelSnapShot()
    {
        
    }
    
    void Start()
    {
        //_templateClass = FindObjectOfType(typeof(TemplateClass)) as TemplateClass;

    }
    
    void Update()
    {
        
    }
}
