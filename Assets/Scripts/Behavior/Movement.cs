using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    [SerializeField] public bool isMoving;
    [SerializeField] public bool isLooping;

    public virtual void FixedUpdate()
    {
        if (isMoving)
        {
            MoveBehavior();
        }
        else
        {
            Deactivate();
        }
    }

    public abstract void MoveBehavior();

    public virtual void Activate()
    {
        isMoving = true;
    }

    public virtual void Deactivate()
    {
        isMoving = false;
    }
}
