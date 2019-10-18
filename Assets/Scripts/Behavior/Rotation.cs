using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : Movement
{
    int direction = 1;
    [SerializeField] bool fullCircle;
    [SerializeField] float angle;
    [SerializeField] float speed;

    Rigidbody2D rbody;
    Quaternion startingPos;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        startingPos = transform.rotation;
    }

    // Update is called once per frame
    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void MoveBehavior()
    {
        if (fullCircle)
        {
            //transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            rbody.angularVelocity = direction * speed;
        }
        else
        {
            if (Quaternion.Angle(startingPos, transform.rotation) >= Mathf.Abs(angle))
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

            if (rbody.angularVelocity != direction * speed && isMoving)
            {
                rbody.angularVelocity = direction * speed;
            }
        }     
    }

    public override void Deactivate()
    {
        base.Deactivate();
        rbody.angularVelocity = 0;
    }
}
