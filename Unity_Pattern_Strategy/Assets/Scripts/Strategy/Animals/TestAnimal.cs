using UnityEngine;
using System.Collections;
using TMPro;

public class TestAnimal : AnimalBase
{
	private TextMeshProUGUI _text;

    private void Awake()
    {
        SetSleep(new SleepBehavior(_text));
        Sleep();
    }


}

