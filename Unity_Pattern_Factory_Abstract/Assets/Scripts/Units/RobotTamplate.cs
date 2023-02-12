using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RobotTamplate : MonoBehaviour
{
    public float Speed { get; set; }
    public string Name { get; set; }

    void Awake()
    {
        SetValues();
    }

    public virtual void SetValues()
    {
        gameObject.name = Name;
    }
    void Update()
    {
        
    }
}
