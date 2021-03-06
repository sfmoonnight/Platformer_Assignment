﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : Movement
{
    [SerializeField] Vector2 direction;
    [SerializeField] float speed;
    [SerializeField] float distance;

    Rigidbody2D rbody;
    Vector2 startingPos;
    Vector2 lastPos;
    [SerializeField] Vector2 endPos;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        startingPos = transform.position;
        endPos = startingPos + direction.normalized * distance;
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    /*private void FixedUpdate()
    {
        lastPos = transform.position;
    }*/

    public override void MoveBehavior()
    {
        if (Vector2.Distance(transform.position, startingPos) > distance)
        {  
            if (isLooping)
            {  
                direction = -direction;            
            }
            else
            {
                Deactivate();         
            }
        }

        if(rbody.velocity != direction.normalized * speed && isMoving)
        {
            rbody.velocity = direction.normalized * speed;
        }        
    }

    public override void Deactivate()
    {
        base.Deactivate();
        rbody.velocity = Vector2.zero;
    }
}
