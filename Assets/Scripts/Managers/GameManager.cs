using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int currentLevel;
    GameObject pauseMenu;
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
            pauseMenu = GameObject.Find("PauseMenu");
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
        HideCursor(currentLevel);
        Toolbox.GetInstance().GetEnergyManager().ResetEnergy();
        Toolbox.GetInstance().GetStatManager().ResetTempScore();
    }

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
        currentLevel = index;
        HideCursor(index);
        Toolbox.GetInstance().GetEnergyManager().ResetEnergy();
        Toolbox.GetInstance().GetStatManager().ResetTempScore();
    }

    public void LoadNextLevel()
    {
        currentLevel += 1;
        SceneManager.LoadScene(currentLevel);
        HideCursor(currentLevel);
        Toolbox.GetInstance().GetEnergyManager().ResetEnergy();
        Toolbox.GetInstance().GetStatManager().UpdateScore();
    }

    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseMenu.GetComponent<CanvasGroup>().alpha = 1;
            pauseMenu.GetComponent<CanvasGroup>().interactable = true;
            Cursor.visible = true;
        }
        else if (Time.timeScale == 0)
        {
            ResumeGame();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.GetComponent<CanvasGroup>().alpha = 0;
        pauseMenu.GetComponent<CanvasGroup>().interactable = false;
        HideCursor(currentLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public int GetCurrentLevel()
    {
        return currentLevel;
    }

    public void HideCursor(int index)
    {
        if (index > 0 && index < 4)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
    }
}
