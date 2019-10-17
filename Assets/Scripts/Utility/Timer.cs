using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Timer: MonoBehaviour
{
    [SerializeField] protected float interval;
    float currentCycle;
    float initTime;
    [SerializeField] protected float duration;
    [SerializeField] protected bool timerOn;

    public abstract void Action();

    private void Update()
    {
        //if(timer)
    }

    public void RepeatCall()
    {
        if(Time.time - currentCycle > interval)
        {
            currentCycle = Time.time;
            Action();
        }
    }

    public virtual void StartTimer()
    {
        timerOn = true;
        initTime = Time.time;
    }

    public virtual void EndTimer()
    {
        timerOn = false;
    }

    public void Countdown()
    {
        if(Time.time - initTime > duration)
        {
            Action();
            EndTimer();
        }
    }

    public void SetInterval(float newInterval)
    {
        interval = newInterval;
    }
}
