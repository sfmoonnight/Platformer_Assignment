using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Timer: MonoBehaviour
{
    int interval = 1;

    // Start is called before the first frame update
    public abstract void RepeatCall();

    // Update is called once per frame
    void Update()
    {
        RepeatCall();
    }
}
