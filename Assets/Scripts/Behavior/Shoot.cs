using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Timer
{
    public GameObject bullet;
    public GameObject instantiatePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            RepeatCall();
        }
    }

    public override void Action()
    {
        Instantiate(bullet, instantiatePoint.transform.position, Quaternion.identity, transform);
    }
}
