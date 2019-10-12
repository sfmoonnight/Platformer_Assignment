using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbox : MonoBehaviour
{
    private static Toolbox _instance;

    public static Toolbox GetInstance()
    {
        if (Toolbox._instance == null)
        {
            var go = new GameObject("Toolbox");
            DontDestroyOnLoad(go);
            Toolbox._instance = go.AddComponent<Toolbox>();
        }
        return Toolbox._instance;
    }

    /* Add your managers here */
    private GameManager gameManager;
    private StatManager statManager;

    void Awake()
    {
        if (Toolbox._instance)
        {
            Destroy(this);
            return;
        }

        var go = new GameObject("Managers");
        DontDestroyOnLoad(go);
        this.gameManager = go.AddComponent<GameManager>();
        this.statManager = go.AddComponent<StatManager>();
    }

    // acess using Toolbox.GetInstance().GetManager();
    public GameManager GetGameManager()
    {
        return this.gameManager;
    }

    public StatManager GetStatManager()
    {
        return this.statManager;
    }
}
