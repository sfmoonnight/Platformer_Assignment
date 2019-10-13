using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    Rigidbody2D rbody;
    GameManager gameManager;
    StatManager statManager;
    EnergyManager energyManager;

    [SerializeField] float speed;
    [SerializeField] float force;
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
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            LateralMove(Vector2.left);
        }
        else if (!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            LateralMove(Vector2.right);
        }

        if (Input.GetKey(KeyCode.Space) && energyManager.GetCurrentEnergy() > 0)
        {
            Thrust();
        }
    }

    void LateralMove(Vector2 direction)
    {
        rbody.AddForce(speed * direction);
    }

    void Thrust()
    {
        rbody.AddForce(force * Vector2.up);
    }
}
