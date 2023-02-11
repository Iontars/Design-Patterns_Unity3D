using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private ArcherFactory archerFactory;
    [SerializeField] private WarriorFactory warriorFactory;
    public void ArcherButton()
    {
        var prefab = archerFactory.GetNewInstance();
    }

    public void WarriorButton()
    {
        var prefab = warriorFactory.GetNewInstance();
    }
}
