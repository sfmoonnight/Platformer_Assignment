using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : Timer
{
    [SerializeField] float energy;
    float maxEnergy;
    [SerializeField] float energyCost = 5;
    [SerializeField] float energyRecover = 3;

    

    private void Start()
    {
        interval = 0.1f;
        maxEnergy = Toolbox.GetInstance().GetStatManager().GetMaxEnergy();
        energy = maxEnergy;
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
}
