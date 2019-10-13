using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Timer: MonoBehaviour
{
    protected float interval = 1;
    float currentCycle;

    float initTime;
    float duration;

    bool timer = true;

    // Update is called once per frame
    void Update()
    {
        if (timer)
        {
            RepeatCall();
        }    
    }

    public abstract void Action();

    void RepeatCall()
    {
        if(Time.time - currentCycle > interval)
        {
            currentCycle = Time.time;
            Action();
        }
    }

    public void StartTimer()
    {
        timer = true;
    }

    public void EndTimer()
    {
        timer = false;
    }

    public void Countdown()
    {
        StartTimer();
        initTime = Time.time;
        if(Time.time - currentCycle > duration)
        {
            EndTimer();
        }
    }
}
