using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlyBehavior : IFly
{
    private TextMeshProUGUI _text;

    public FlyBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Fly()
    {
        ShowText(_text, "я лечу");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}
