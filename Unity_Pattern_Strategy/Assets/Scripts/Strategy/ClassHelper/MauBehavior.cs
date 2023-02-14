using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MauBehavior : ISpeak
{
    private TextMeshProUGUI _text;

    public MauBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Speak()
    {
        ShowText(_text, "мяу мяу я мяукаю");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}
