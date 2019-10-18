using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        Toolbox.GetInstance().GetGameManager().LoadLevel(0);
        Time.timeScale = 1;
        //Toolbox.GetInstance().GetGameManager().ResumeGame();
        Toolbox.GetInstance().GetStatManager().ResetStats();
    }
}
