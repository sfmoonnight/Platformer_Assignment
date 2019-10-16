using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    [SerializeField] public bool isMoving;
    [SerializeField] public bool isLooping;

    public virtual void Update()
    {
        if (isMoving)
        {
            MoveBehavior();
        }
    }

    public abstract void MoveBehavior();

    public void Activate()
    {
        isMoving = false;
    }

    public void Deactivate()
    {
        isMoving = true;
    }
}
