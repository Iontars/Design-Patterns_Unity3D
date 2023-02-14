using UnityEngine;
using System.Collections;
using TMPro;

public class CanNotBehavior : ICanNot
{
    private TextMeshProUGUI _text;

    public CanNotBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void CanNot()
    {
        ShowText(_text, " не могу");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}

