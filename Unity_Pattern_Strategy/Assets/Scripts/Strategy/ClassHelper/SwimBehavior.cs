using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SwimBehavior : ISwim
{
    private TextMeshProUGUI _text;

    public SwimBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Swim()
    {
        ShowText(_text, "я плыву");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}
