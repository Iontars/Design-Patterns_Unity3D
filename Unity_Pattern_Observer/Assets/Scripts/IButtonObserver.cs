using System;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public interface IButtonObserver
{
    public abstract event Action setButtonPressed;
    public abstract void PressButton();

}
