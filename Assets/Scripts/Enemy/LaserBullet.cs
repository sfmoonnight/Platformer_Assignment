using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : ImpulseMovement
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        direction = transform.parent.transform.up;
        MoveBehavior();
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }
}
