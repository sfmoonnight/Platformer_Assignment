using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : Timer
{
    public GameObject sprite;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            Countdown();
        }
    }

    public override void Action()
    {
        sprite.SetActive(false);
    }

    public override void StartTimer()
    {
        base.StartTimer();
        //playanimation
        if (anim)
        {
            anim.SetTrigger("dissappear");
        }
    }
}
