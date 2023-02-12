using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType { gun, laser }
public enum FarmerToolType { farmToolT1, farmToolT2 }
public enum WorkerToolType { workerToolT1, workerToolT2 }

public class RobotsFunctional : MonoBehaviour
{
    public  WeaponType weaponType = new();
    public FarmerToolType farmerToolType = new();
    public WorkerToolType workerToolType = new();
}
