using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBase : MonoBehaviour
{
    #region Variable
    protected float speed = 0.2f;
    protected float timer = 4;

    protected ISpeak speakBehavior;
    protected ICanNot canNotBehavior;
    protected IEat eatBehavior;
    protected IFly flyBehavior;
    protected IMove moveBehavior;
    protected ISleep sleepBehavior;
    protected ISwim swimBehavior;

    #endregion
    #region Internet init
    public void SpeakBehavior(ISpeak speakBehavior)
    {
        this.speakBehavior = speakBehavior;
    }

    #endregion
}
