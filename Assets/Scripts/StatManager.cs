using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public float score;
    public float maxEnergy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(float newScore)
    {
        score = newScore;
    }

    public float GetScore()
    {
        return score;
    }

    public void UpdateMaxEnergy(float newMaxEnergy)
    {
        maxEnergy = newMaxEnergy;
    }

    public float GetMaxEnergy()
    {
        return maxEnergy;
    }
}
