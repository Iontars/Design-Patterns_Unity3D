using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Difficult{ easy, normal, hard }

[RequireComponent(typeof(GameManager))]
public class GameManager : MonoBehaviour
{
    [Header("Components Stuff")][Space(3)]
    public Text currentText;
    public StartButton startButton;

    private GameObject[] _setButtons;
    private List<IButtonObserver> _publisherButtons;
    private Difficult _difficult_e;
    private byte _counter = default;

    private void Awake()
    {
        _setButtons = GameObject.FindGameObjectsWithTag("SetButton");
        _publisherButtons = new();
        for (int i = 0; i < _setButtons.Length; i++)
        {
            _publisherButtons.Add(_setButtons[i].GetComponent<SetDifficult>());
        }
    }

    private void ChooseDifficult()
    {
        if (++_counter > Convert.ToInt32(Difficult.hard)) _counter = default; // последнее значение enum, есть его размер
        switch (_counter)
        {
            case default(byte): _difficult_e = Difficult.easy; break;
            case 1: _difficult_e = Difficult.normal; break;
            case 2: _difficult_e = Difficult.hard; break;
        }
        gameObject.GetComponent<GameManager>()?.DisplayInfoOnTEXT(currentText, _difficult_e);
    }

    public void DisplayInfoOnTEXT<T>(Text textComponent, T enumValue ) => textComponent.text = enumValue.ToString();

    private void OnEnable()
    {
        foreach (var item in _publisherButtons)
        {
            item.setButtonPressed += ChooseDifficult;
        }
    }
    private void OnDisable()
    {
        foreach (var item in _publisherButtons)
        {
            item.setButtonPressed -= ChooseDifficult;
        }
    }
}
