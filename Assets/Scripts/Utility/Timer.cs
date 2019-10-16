using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Timer: MonoBehaviour
{
    [SerializeField] protected float interval;
    float currentCycle;
    float initTime;
    [SerializeField] protected float duration;
    [SerializeField] protected bool timer;

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
        timer = true;
    }

    public virtual void EndTimer()
    {
        timer = false;
    }

    public void Countdown()
    {
        StartTimer();
        initTime = Time.time;
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
