using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewLevel()
    {
        Toolbox.GetInstance().GetGameManager().Reload();
        Toolbox.GetInstance().GetGameManager().ResumeGame();
    }
}
