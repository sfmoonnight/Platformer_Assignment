using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Image energyBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowEnergy();
    }

    void ShowEnergy()
    {
        float energy = Toolbox.GetInstance().GetEnergyManager().GetCurrentEnergy();
        float maxEnergy = Toolbox.GetInstance().GetStatManager().GetMaxEnergy();
        energyBar.GetComponent<Image>().fillAmount = energy / maxEnergy;
    }
}
