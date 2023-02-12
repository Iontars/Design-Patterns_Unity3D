using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class RobotFarmerT1 : RobotTamplate
{
    FarmerToolType farmerTool;
    public new float Speed => 7f;
    public new string Name => "WALL-E";

     void Awake()
    {
        gameObject.name = Name;
        GetComponent<SpriteRenderer>().color = new UnityEngine.Color(0, 182f, 115f);
        farmerTool = FarmerToolType.farmToolT1;
    }


    void Update()
    {
        
    }
}
