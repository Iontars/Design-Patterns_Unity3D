using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SleepBehavior : ISleep
{
    private TextMeshProUGUI _text;

    public SleepBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Sleep()
    {
        ShowText(_text,"я люблю спать");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }


}
