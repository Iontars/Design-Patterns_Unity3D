using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;

public class Parrot : AnimalBase
{
    public Dictionary<string, Action> behaviors;
    [SerializeField] private Material material;
    [SerializeField] private TextMeshProUGUI text;
    //private float timer = 4f;

    private void Awake()
    {
        SetSpeakBehavior(new SpeakAsHumanBehavior(text));
        SetMove(new TwoLegsBehavior(text));
        SetEat(new EatBehavior(text));
        SetSleep(new SleepBehavior(text));
        SetCanNot(new CanNotBehavior(text));

        behaviors = new()
        {
            {"speak", Speak },
            {"move", Move },
            {"eat", Eat },
            {"sleep", Sleep },
            {"canNot", CanNot },
        };
    }

    private void OnMouseDown()
    {
        print("1");
        PanelController.panelController.Reset();
        PanelController.panelController.currentAnimal = this;
        PanelController.panelController.behaviors = behaviors;
    }
}
