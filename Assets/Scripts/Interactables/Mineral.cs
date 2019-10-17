using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mineral : RocketInteractable
{
    [SerializeField] float point;
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
        Toolbox.GetInstance().GetStatManager().AddToScore(point);
    }
}
