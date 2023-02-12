using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BawBehavior : ISpeak
{
    private TextMeshProUGUI _text;

    public BawBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Speak()
    {
        ShowText(_text, "гав гав я лаю");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }

}
