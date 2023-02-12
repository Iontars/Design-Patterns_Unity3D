using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFarmerT2 : RobotTamplate
{
    FarmerToolType farmerTool;
    public new float Speed => 10f;
    public new string Name => "Mega WALL-E";
    void Awake()
    {
        SetValues(Name);
        GetComponentsInChildren<SpriteRenderer>()[0].color = new UnityEngine.Color(0, 200f, 115f);
        GetComponentsInChildren<SpriteRenderer>()[1].color = new UnityEngine.Color(0, 200f, 115f);
        farmerTool = FarmerToolType.farmToolT2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
