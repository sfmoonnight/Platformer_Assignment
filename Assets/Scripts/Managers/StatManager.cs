using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public float score = 0;
    public float maxEnergy = 100;

    float tempScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score = tempScore;
    }

    public void AddToScore(float point)
    {
        tempScore += point;
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

    public void ResetStats()
    {
        score = 0;
        tempScore = 0;
        maxEnergy = 100;
    }

    public void ResetTempScore()
    {
        tempScore = score;
    }
}
