using System;
using UnityEngine;

public class SetDifficult : MonoBehaviour, IButtonObserver
{
    public event Action setButtonPressed;

    public void PressButton() => setButtonPressed?.Invoke();

}
