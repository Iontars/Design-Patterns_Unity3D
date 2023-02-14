using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FourLegsBehavior : IMove
{
    private TextMeshProUGUI _text;

    public FourLegsBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Move()
    {
        ShowText(_text, "Двигаюсь на 4 ногах");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}
