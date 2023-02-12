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
    public void SetSpeakBehavior(ISpeak speakBehavior)
    {
        this.speakBehavior = speakBehavior;
    }

    public void SetCanNot(ICanNot canNotBehavior)
    {
        this.canNotBehavior = canNotBehavior;
    }

    public void SetEat(IEat eatBehavior)
    {
        this.eatBehavior = eatBehavior;
    }

    public void SetFly(IFly flyBehavior)
    {
        this.flyBehavior = flyBehavior;
    }

    public void SetMove(IMove moveBehavior)
    {
        this.moveBehavior = moveBehavior;
    }

    public void SetSleep(ISleep sleepBehavior)
    {
        this.sleepBehavior = sleepBehavior;
    }

    public void SetSwim(ISwim swimBehavior)
    {
        this.swimBehavior = swimBehavior;
    }

    #endregion

    #region Base

    protected void Sleep() => sleepBehavior.Sleep();
    protected void Eat() => eatBehavior.Eat();
    protected void Move() => moveBehavior.Move();
    protected void Speak() => speakBehavior.Speak();
    protected void CanNot() => canNotBehavior.CanNot();
    protected void Swim() => swimBehavior.Swim();
    protected void Fly() => flyBehavior.Fly();

    #endregion
}
