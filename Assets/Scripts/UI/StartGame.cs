﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Toolbox.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        Toolbox.GetInstance().GetGameManager().LoadLevel(1);
    }
}
