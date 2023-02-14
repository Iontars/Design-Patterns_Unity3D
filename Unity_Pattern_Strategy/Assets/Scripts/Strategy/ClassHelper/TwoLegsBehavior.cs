using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TwoLegsBehavior : IMove
{
    // Start is called before  first frame update
    private TextMeshProUGUI _text;

    public TwoLegsBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Move()
    {
        ShowText(_text, "Двигаюсь на 2 ногах");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}
