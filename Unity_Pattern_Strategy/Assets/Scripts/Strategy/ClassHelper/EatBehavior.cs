using UnityEngine;
using System.Collections;
using TMPro;

public class EatBehavior : IEat
{
    private TextMeshProUGUI _text;

    public EatBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Eat()
    {
        ShowText(_text, " я ем");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}

