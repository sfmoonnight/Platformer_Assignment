using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissappearable : RocketInteractable
{
    public Disappear dis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnHit()
    {
        dis.StartTimer();
    }
}
