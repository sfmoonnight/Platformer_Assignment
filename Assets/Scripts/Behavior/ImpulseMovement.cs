using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseMovement : MonoBehaviour
{
    public Vector2 direction;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    public virtual void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public void MoveBehavior()
    {
        rbody.AddForce(direction, ForceMode2D.Impulse);
    }
}
