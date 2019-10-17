using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAndOff : Timer
{
    bool actuating;
    public GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            RepeatCall();
        }
    }

    public override void Action()
    {
        sprite.SetActive(Switch());
    }

    bool Switch()
    {
        if (actuating)
        {
            actuating = false;
        }
        else
        {
            actuating = true;
        }

        return actuating;
    }
}
