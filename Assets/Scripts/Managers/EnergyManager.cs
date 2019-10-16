﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : Timer
{
    [SerializeField] float energy;
    float maxEnergy;
    [SerializeField] float energyCost = 2;
    [SerializeField] float energyRecover = 3;

    

    private void Start()
    {
        SetInterval(0.1f);
        StartTimer();
        maxEnergy = Toolbox.GetInstance().GetStatManager().GetMaxEnergy();
        ResetEnergy();
    }

    private void Update()
    {
        if (timer)
        {
            RepeatCall();
        }
    }

    public override void Action()
    {
        if (Input.GetKey(KeyCode.Space) && energy > 0)
        {
            UseEnergy();
        }
        if(energy < maxEnergy && !Input.GetKey(KeyCode.Space))
        {
            RecoverEnergy();
        }

        energy = Mathf.Clamp(energy, 0, maxEnergy);
    }

    public void UseEnergy()
    {
        energy -= energyCost;
    }

    public void RecoverEnergy()
    {
        energy += energyRecover;
    }

    public float GetCurrentEnergy()
    {
        return energy;
    }

    public void ResetEnergy()
    {
        energy = maxEnergy;
    }
}
