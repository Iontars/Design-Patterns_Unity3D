using UnityEngine;
using System.Collections;
using TMPro;

public class SpeakBehavior : ISpeak
{
    private TextMeshProUGUI _text;

    public SpeakBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Speak()
    {
        ShowText(_text, " говорю ");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}

