using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
/// <summary>
/// 
/// </summary>
public class Client : MonoBehaviour
{
    public MainClass mainClass;
    [SerializeField]
    Forest _forest;
    Meadow _meadow;

    void Awake()
    {
        
    }
   
    void Start()
    {
        mainClass.AnyMethod(_forest);
        mainClass.AnyMethod(_meadow);
    }
    
    void Update()
    {
        
    }
}
