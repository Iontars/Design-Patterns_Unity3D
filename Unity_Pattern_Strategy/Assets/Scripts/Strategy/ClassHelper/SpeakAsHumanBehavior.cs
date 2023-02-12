using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeakAsHumanBehavior : MonoBehaviour
{
    private TextMeshProUGUI _text;

    public SpeakAsHumanBehavior(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void Speak()
    {
        ShowText(_text, "чырык чырык");
    }

    public void ShowText(TextMeshProUGUI text, string message)
    {
        text.gameObject.SetActive(true);
        text.text = message;
    }
}
