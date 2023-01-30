using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
/// <summary>
/// 
/// </summary>
public class Meadow : MonoBehaviour, IWayOut
{
    [HideInInspector]
    public string direction = "Right";

    public string Direction { get => direction; }

    void IWayOut.GoingOut()
    {
        print(direction);
    }

    public void GetMessage() // unreachable for MainClass through Interfase obj
    {
        print("Test");
    }

    void Start()
    {

    }
    
    void Update()
    {
        
    }
}
