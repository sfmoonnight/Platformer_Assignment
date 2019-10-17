using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketInteraction : MonoBehaviour
{
    Rigidbody2D rbody;
    GameManager gameManager;
    StatManager statManager;
    EnergyManager energyManager;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        gameManager = Toolbox.GetInstance().GetGameManager();
        statManager = Toolbox.GetInstance().GetStatManager();
        energyManager = Toolbox.GetInstance().GetEnergyManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.TryGetComponent(out RocketInteractable rocketInteractable))
        {
            print("hit");
            RocketInteractable[] ris = collision.collider.GetComponents<RocketInteractable>();
            foreach(RocketInteractable ri in ris)
            {
                ri.OnHit();
            }           
        }
    }
}
