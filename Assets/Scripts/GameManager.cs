using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float energy;
    [SerializeField] float eConsumingRate;
    // Start is called before the first frame update
    void Start()
    {
        energy = Toolbox.GetInstance().GetStatManager().GetMaxEnergy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UseEnergy()
    {
        energy -= eConsumingRate;
    }

    public float GetCurrentEnergy()
    {
        return energy;
    }
}
