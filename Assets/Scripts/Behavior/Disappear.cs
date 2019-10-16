using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : Timer
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer)
        {
            Countdown();
        }
    }

    public override void Action()
    {
        //disappear
    }

    public override void StartTimer()
    {
        base.StartTimer();
        //playanim
    }
}
