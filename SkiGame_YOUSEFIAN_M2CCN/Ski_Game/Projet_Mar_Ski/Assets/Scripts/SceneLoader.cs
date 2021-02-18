using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //Public Variable


    //Private Varible


    //Private Method
    private void Update()
    {
       
    }

    //Public Method
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadScene(string name)
    {
        print("scene");
        SceneManager.LoadScene(name);
    }
    public void ExitGame()
    {
        print("scene");
        Application.Quit();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
