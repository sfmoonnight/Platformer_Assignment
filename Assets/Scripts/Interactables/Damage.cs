﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : RocketInteractable
{
    
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
        print("Reload");
        Toolbox.GetInstance().GetGameManager().Reload();
    }
}
