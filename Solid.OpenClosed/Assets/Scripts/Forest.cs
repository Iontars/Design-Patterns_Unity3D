using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
/// <summary>
/// 
/// </summary>
public class Forest : MonoBehaviour, IWayOut
{
    public string direction = "Left";

    void IWayOut.GoingOut()
    {
        print(direction);
    }
   
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
