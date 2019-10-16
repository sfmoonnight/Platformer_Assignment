using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : Movement
{
    [SerializeField] Vector2 direction;
    [SerializeField] float speed;
    [SerializeField] float distance;

    Rigidbody2D rbody;
    Vector2 startingPos;
    Vector2 endPos;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        startingPos = transform.position;
        endPos = startingPos + direction.normalized * distance;
    }

    public override void Update()
    {
        base.Update();
    }

    public override void MoveBehavior()
    {
        if(Vector2.Distance(transform.position, startingPos) > distance)
        {
            direction = -direction;
        }
        rbody.velocity = direction.normalized * speed;
    }
}
