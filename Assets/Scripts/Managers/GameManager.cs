using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void Reload()
    {
        //print("Retrieving buildIndex " + SceneManager.GetActiveScene().buildIndex + " current index " + currentLevel);
        //print("Scene name" + SceneManager.GetSceneAt(currentLevel).name);
        //SceneManager.UnloadScene(currentLevel);
        //SceneManager.LoadScene(2);
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(currentLevel);
    }

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
        currentLevel = index;
    }

    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
